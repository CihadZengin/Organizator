using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duzenleyici
{
    public partial class Kayıt : Form
    {
        private int KurulumID =0;
        private int ArizaID = 0;
        public Kayıt()
        {
            InitializeComponent();
        }

        private void Kayıt_Load(object sender, EventArgs e)
        {
            grbarıza.Enabled = false;
            grbkurulum.Enabled = false;
            btnakayıt.Enabled = false;
            btnkkayıt.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd- MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
        }

        private void btnkurulum_Click(object sender, EventArgs e)
        {
            grbarıza.Enabled = false;
            grbkurulum.Enabled = true;
            btnakayıt.Enabled = false;
            btnkkayıt.Enabled = true;
            KurulumFiilcomboboxmusteri();
        }

        private void btnariza_Click(object sender, EventArgs e)
        {
            grbarıza.Enabled = true;
            grbkurulum.Enabled = false;
            btnakayıt.Enabled = true;
            btnkkayıt.Enabled = false;
            ArizaFillcomboboxmusteri();
        }
        private void ArizaFillcomboboxmusteri()
        {
            try
            {
                
                string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection con = new SqlConnection(bağlantı))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Select MusteriAdi From Musteri_tbl", con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            txtaad.Items.Clear();
                            while (reader.Read())
                            {
                                txtaad.Items.Add(reader["MusteriAdi"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Musteri Adı Alınırken Bir Hata Oluştu : {ex.Message}","SQL Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void KurulumFiilcomboboxmusteri()
        {
            try
            {

                string bağlantık = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection conk = new SqlConnection(bağlantık))
                {
                    conk.Open();
                    using (SqlCommand cmd = new SqlCommand("Select MusteriAdi From Musteri_tbl", conk))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            txtkad.Items.Clear();
                            while (reader.Read())
                            {
                                txtkad.Items.Add(reader["MusteriAdi"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Musteri Adı Alınırken Bir Hata Oluştu : {ex.Message}", "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ArızaGetCastomerInfıMusteri(string madi)
        {
            try
            {
                string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection con = new SqlConnection(bağlantı))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Select MusteriSoyadi, MusteriTelNo From Musteri_tbl Where MusteriAdi = @p1", con))
                    {
                        cmd.Parameters.AddWithValue("@p1", madi);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtasoyad.Text = reader["MusteriSoyadi"].ToString();
                                txtatel.Text = reader["MusteriTelNo"].ToString();
                            }
                            else
                            {
                                txtasoyad.Clear();
                                txtatel.Clear();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Veritabanında Bir Hata Oluştu {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } 
        }
        private void KurulumGetCastomerInfoMusteri(string kmadi)
        {
            try
            {
                string bağlantık = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection conk = new SqlConnection(bağlantık))
                {
                    conk.Open();
                    using (SqlCommand cmd = new SqlCommand("Select MusteriSoyadi, MusteriTelNo From Musteri_tbl Where MusteriAdi = @p1", conk))
                    {
                        cmd.Parameters.AddWithValue("@p1", kmadi);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtksoyad.Text = reader["MusteriSoyadi"].ToString();
                                txtktel.Text = reader["MusteriTelNo"].ToString();
                            }
                            else
                            {
                                txtksoyad.Clear();
                                txtktel.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanında Bir Hata Oluştu {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtaad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtaad.SelectedItem == null)
                return;
            string selectedaad = txtaad.SelectedItem.ToString();
            ArızaGetCastomerInfıMusteri(selectedaad);
        }

        private void txtkad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtkad.SelectedItem == null)
                return;
            string selectedkad =  txtkad.SelectedItem.ToString();
            KurulumGetCastomerInfoMusteri(selectedkad);
        }
        private void SaveDateaa(DateTime selectedDate)
        {
            string FormattedDate = selectedDate.ToString("dd-MM-yyyy");
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    con.Open();
                    string checkquery = "select TarihID from Tarih_tbl Where tarihler =@p1";
                    object result;
                    using (SqlCommand checkcmd = new SqlCommand(checkquery, con))
                    {
                        checkcmd.Parameters.AddWithValue("@p1", FormattedDate);
                        result = checkcmd.ExecuteScalar();
                    }
                    if (result == null)
                    {
                        string insertquery = "insert into Tarih_tbl (Tarihler) values (@p1)";
                        using (SqlCommand insertcmd = new SqlCommand(insertquery,con))
                        {
                            insertcmd.Parameters.AddWithValue("@p1",FormattedDate);
                            insertcmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabanında Bir Hata Oluştu {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void SaveDatek(DateTime selectedDate)
        {
            string FormattedDate = selectedDate.ToString("dd-MM-yyyy");
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    con.Open();
                    string checkquery = "select TarihID from Tarih_tbl Where tarihler =@p1";
                    object result;
                    using (SqlCommand checkcmd = new SqlCommand(checkquery, con))
                    {
                        checkcmd.Parameters.AddWithValue("@p1", FormattedDate);
                        result = checkcmd.ExecuteScalar();
                    }
                    if (result == null)
                    {
                        string insertquery = "insert into Tarih_tbl (Tarihler) values (@p1)";
                        using (SqlCommand insertcmd = new SqlCommand(insertquery, con))
                        {
                            insertcmd.Parameters.AddWithValue("@p1", FormattedDate);
                            insertcmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabanında Bir Hata Oluştu {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1 == null)
                return;
            DateTime selectedDate = dateTimePicker1.Value;
            SaveDateaa(selectedDate);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2 == null)
                return;
            DateTime selectedDate1 = dateTimePicker2.Value;
            SaveDatek(selectedDate1);
        }
        private int GetMusteriIDa(string madia)
        {
            int id = -1;
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select MusteriID from Musteri_tbl Where MusteriAdi=@p1",con);
                    cmd.Parameters.AddWithValue("@p1", madia);
                    var result = cmd.ExecuteScalar();
                    if(result != null)
                    {
                        id= Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabanında Bir Hata Oluştu {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }return id;
        }
        private int GetMusteriIDk(string madia)
        {
            int id = -1;
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select MusteriID from Musteri_tbl Where MusteriAdi=@p1", con);
                    cmd.Parameters.AddWithValue("@p1", madia);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        id = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabanında Bir Hata Oluştu {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            return id;
        }
        private int GetTarihID(DateTime tarih)
        {
            int id = -1;
            string formattedDate = tarih.ToString("dd-MM-yyyy");
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT TarihID FROM Tarih_tbl WHERE Tarihler = @p1", con))
                    {
                        cmd.Parameters.AddWithValue("@p1", formattedDate);
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            id = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Tarih ID alınırken hata: " + ex.Message); }
            }
            return id;
        }
        private int GetTarihIDk(DateTime tarih)
        {
            int id = -1;
            string formattedDate = tarih.ToString("dd-MM-yyyy");
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT TarihID FROM Tarih_tbl WHERE Tarihler = @p1", con))
                    {
                        cmd.Parameters.AddWithValue("@p1", formattedDate);
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            id = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Tarih ID alınırken hata: " + ex.Message); }
            }
            return id;
        }

        private void btnakayıt_Click(object sender, EventArgs e)
        {
            if(txtaad.SelectedItem == null )
            {
                MessageBox.Show("Lütfen Seçilmesi Gereken Tüm Alanları Seçiniz");
                return;
            }
            int musteriID = GetMusteriIDa(txtaad.Text);
            int tarihID = GetTarihID(dateTimePicker1.Value);

            if (musteriID ==-1 || tarihID ==-1)
            {
                MessageBox.Show("Eksik Veya Hatalı Bilgi Var!!! (ID Ler Alınamadı)");
                return;
            }

            string Not = txtanot.Text;
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {    
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("insert into Ariza_tbl(AMusteriID,ArizaTarihiID,ArizaNot) values(@p1,@p2,@p3)", con))
                    {
                        cmd.Parameters.AddWithValue("@p1",musteriID);
                        cmd.Parameters.AddWithValue("@p2",tarihID);
                        cmd.Parameters.AddWithValue("@p3",Not);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Başarılı Bir Şekilde Arıza Kaydı Alındı");
                    }
                    txtaad.SelectedIndexChanged -= txtaad_SelectedIndexChanged;
                    txtaad.SelectedIndex = -1;
                    txtasoyad.Clear();
                    txtatel.Clear();
                    
                    txtanot.Clear();
                    txtaad.SelectedIndexChanged += txtaad_SelectedIndexChanged;
                }
                catch (Exception ex) { MessageBox.Show("Arıza eklenirken hata: " + ex.Message); }
            }


        }

        private void btnkkayıt_Click(object sender, EventArgs e)
        {
            if (txtkad.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Seçilmesi Gereken Tüm Alanları Seçiniz");
                return;
            }
            int musteriID = GetMusteriIDk(txtkad.Text);
            int tarihID = GetTarihIDk(dateTimePicker2.Value);

            if (musteriID == -1 || tarihID == -1)
            {
                MessageBox.Show("Eksik Veya Hatalı Bilgi Var!!! (ID Ler Alınamadı)");
                return;
            }

            string Notk = txtknot.Text;
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("insert into Kurulum_tbl(kMusteriID,KurulumTarihiID,KurulumNot) values(@p1,@p2,@p3)", con))
                    {
                        cmd.Parameters.AddWithValue("@p1", musteriID);
                        cmd.Parameters.AddWithValue("@p2", tarihID);
                        cmd.Parameters.AddWithValue("@p3", Notk);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Başarılı Bir Şekilde Kurulum Kaydı Alındı");
                    }
                    txtkad.SelectedIndexChanged -= txtaad_SelectedIndexChanged;
                    txtkad.SelectedIndex = -1;
                    txtksoyad.Clear();
                    txtktel.Clear();
                    
                    txtknot.Clear();
                    txtkad.SelectedIndexChanged += txtaad_SelectedIndexChanged;
                }
                catch (Exception ex) { MessageBox.Show("Kurulum eklenirken hata: " + ex.Message); }
            }
        }
    }  
}
