using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duzenleyici
{
    public partial class Kullanicilar : Form
    {
        private int ID = 0;
        public Kullanicilar()
        {
            InitializeComponent();
        }
        private void verileritazele()
        {
            try
            {
                string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection con = new SqlConnection(bağlantı))
                {
                    string query = "Select * From Login_tbl";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapt = new SqlDataAdapter(query, bağlantı);
                        adapt.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                if (dataGridView1.Columns.Contains("LoginID"))
                {
                    dataGridView1.Columns["LoginID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanında Bir Hata Oluştu : {ex.Message}", "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            verileritazele();
        }
        private string HashSifre(string sifre)
        {
            using (SHA256 sHA256Hash = SHA256.Create())
            {
                byte[] bytes = sHA256Hash.ComputeHash(Encoding.UTF8.GetBytes(sifre));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));

                }
                return builder.ToString();
            }
        }
        private void Temizle()
        {
            txtkuladi.Clear();
            txtkulsifre.Clear();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtkuladi.Text) || string.IsNullOrWhiteSpace(txtkulsifre.Text) || string.IsNullOrWhiteSpace(cmbxkulstatu.Text))
                {
                    MessageBox.Show("Lütfen Bilgileri Eksiksiz Bir Şekilde Doldurunuz");
                    return;
                }
                string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection con = new SqlConnection(bağlantı))
                {
                    string Kullanicistatusu = cmbxkulstatu.Text;
                    string Kullaniciadi = txtkuladi.Text;
                    string hashlenmisSifre = HashSifre(txtkulsifre.Text);

                    con.Open();
                    string query = "insert into Login_tbl(Kullanicistatusu,KullaniciAdi,Sifre) Values(@p1,@p2,@p3)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@p1", Kullanicistatusu);
                        cmd.Parameters.AddWithValue("@p2", Kullaniciadi);
                        cmd.Parameters.AddWithValue("@p3", hashlenmisSifre);
                        cmd.ExecuteNonQuery();
                    }
                    verileritazele();
                    Temizle();
                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Eklendi");
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show($"Veritabanında Bir Hata Oluştu : {ex1.Message}", "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                string idcolumname = "LoginID";
                string Kullaniciadicolumname = "KullaniciAdi";
                string KullaniciStatusuname = "Kullanicistatusu";

                if (dataGridView1.Columns.Contains(idcolumname) && dataGridView1.Rows[e.RowIndex].Cells[idcolumname].Value != null && dataGridView1.Rows[e.RowIndex].Cells[idcolumname].Value != DBNull.Value)
                {
                    ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[idcolumname].Value);

                }
                else
                {
                    MessageBox.Show("Seçilen Satırda Geçerli Bir Id Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ID = 0;
                    Temizle();
                    return;
                }
                if (dataGridView1.Columns.Contains(Kullaniciadicolumname))
                {
                    txtkuladi.Text = dataGridView1.Rows[e.RowIndex].Cells[Kullaniciadicolumname].Value.ToString() ?? string.Empty;
                }
                txtkulsifre.Clear();
                if (dataGridView1.Columns.Contains(KullaniciStatusuname))
                {
                    cmbxkulstatu.Text = dataGridView1.Rows[e.RowIndex].Cells[KullaniciStatusuname].Value.ToString() ?? string.Empty;
                }
                txtkulsifre.Clear();

            }
            catch (FormatException ex)
            {
                MessageBox.Show($"ID Formatında Bir Hata Oluştu : {ex.Message}", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID = 0;
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Oluştu : {ex.Message}", "Genel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID = 0;
                Temizle();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID == 0)
                {
                    MessageBox.Show("Lütfen Düzenlemek İçin Bir Kayıt Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtkuladi.Text))
                {
                    MessageBox.Show("Kullanıcı Adı Boş Bırakılmaz");
                }
                string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection con = new SqlConnection(bağlantı))
                {
                    string sqlquery;
                    SqlCommand cmd;
                    if (!string.IsNullOrWhiteSpace(txtkulsifre.Text))
                    {
                        string heshlenmisSifre = HashSifre(txtkulsifre.Text);
                        sqlquery = "Update Login_tbl set KullaniciStatusu=@p1,KullaniciAdi=@p2,Sifre=@p3 where LoginID=@ID";
                        cmd = new SqlCommand(sqlquery, con);
                        cmd.Parameters.AddWithValue("@p3", heshlenmisSifre);
                    }
                    else
                    {
                        sqlquery = "Update Login_tbl set KullaniciAdi=@p2 where LoginID=@ID";
                        sqlquery = "Update Login_tbl set KullaniciStatusu=@p1 where LoginID=@ID";
                        cmd = new SqlCommand(sqlquery, con);
                    }
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@p2", txtkuladi.Text);
                        cmd.Parameters.AddWithValue("@p1", cmbxkulstatu.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    verileritazele();
                    MessageBox.Show("Kullanıcı Bilgileri Başarılı Bir Şekilde Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    ID = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Genel Bir Hata Oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Lütfen Silmek İçin Bir Kayıt Seçiniz.");
                return;
            }
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("Delete From Login_tbl where LoginID =@ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    verileritazele();
                    MessageBox.Show("Kullanıcı Bilgileri Başarılı Bir Şekilde Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    ID = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kayıt Silme İşleminde Bir Hata Oluştu : {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            try
            {
                string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection con = new SqlConnection(bağlantı))
                {
                    DataTable dt = new DataTable();
                    string query = "select * from Login_tbl where KullaniciAdi Like @ara";

                    using (SqlDataAdapter adpara = new SqlDataAdapter(query, con))
                    {
                        adpara.SelectCommand.Parameters.AddWithValue("@ara", txtara.Text);
                        adpara.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Arama İşlemi Sırasında Bir Hata Oluştu: {ex.Message}","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verileritazele();
            txtara.Clear();
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                string idColumnName = "LoginID";
                string kullaniciAdiColumnName = "KullaniciAdi";
                string kullanicistatusu = "KullaniciStatusu";


                if (dataGridView1.Columns.Contains(idColumnName) && dataGridView1.Rows[e.RowIndex].Cells[idColumnName].Value != null && dataGridView1.Rows[e.RowIndex].Cells[idColumnName].Value != DBNull.Value)
                {
                    ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[idColumnName].Value);
                }
                else
                {
                    MessageBox.Show("Seçili satırda geçerli bir ID bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ID = 0;
                    Temizle();
                    return;
                }

                if (dataGridView1.Columns.Contains(kullaniciAdiColumnName))
                {
                    txtkuladi.Text = dataGridView1.Rows[e.RowIndex].Cells[kullaniciAdiColumnName].Value?.ToString() ?? string.Empty;
                }
                txtkulsifre.Clear();
                if (dataGridView1.Columns.Contains(kullanicistatusu))
                {
                    cmbxkulstatu.Text = dataGridView1.Rows[e.RowIndex].Cells[kullanicistatusu].Value?.ToString() ?? string.Empty;
                }
                txtkulsifre.Clear();

            }
            catch (FormatException ex)
            {
                MessageBox.Show($"ID formatında bir hata oluştu: {ex.Message}", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID = 0;
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Genel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID = 0;
                Temizle();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verileritazele();
            Temizle();
            ID = 0; 
        }
    }
    
}
