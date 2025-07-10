using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duzenleyici
{
    
    public partial class Stok_Durumu : Form
    {
        private int ID =0 ;
        public Stok_Durumu()
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
                    string query = "Select * From Stok_tbl";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapt = new SqlDataAdapter(query, bağlantı);
                        adapt.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                if (dataGridView1.Columns.Contains("StokID"))
                {
                    dataGridView1.Columns["StokID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanında Bir Hata Oluştu : {ex.Message}", "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Stok_Durumu_Load(object sender, EventArgs e)
        {
            verileritazele();
        }
        private void temizle()
        {
            txtutur.Clear();
            txtuadi.Clear();
            txtuadet.Clear();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtutur.Text) || string.IsNullOrWhiteSpace(txtuadi.Text) || string.IsNullOrWhiteSpace(txtuadet.Text)) 
                {
                    MessageBox.Show("Lütfen Bilgileri Eksiksiz Bir Şekilde Doldurunuz");
                    return;
                }
                string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection con = new SqlConnection(bağlantı))
                {
                    con.Open();
                    string query = "insert into Stok_tbl(ÜrünTürü,ÜrünAdi,ÜrünAdeti) Values(@p1,@p2,@p3)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@p1", txtutur.Text);
                        cmd.Parameters.AddWithValue("@p2", txtuadi.Text);
                        cmd.Parameters.AddWithValue("@p3", txtuadet.Text);
                        cmd.ExecuteNonQuery();
                    }
                    verileritazele();
                    MessageBox.Show("Ürün Başarılı Bir Şekilde Eklendi");
                    temizle();
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
                string idcolumname = "StokID";
                string uruntur = "ÜrünTürü";
                string urunadicolumname = "ÜrünAdi";
                string urunadet = "ÜrünAdeti";

                if (dataGridView1.Columns.Contains(idcolumname) && dataGridView1.Rows[e.RowIndex].Cells[idcolumname].Value != null && dataGridView1.Rows[e.RowIndex].Cells[idcolumname].Value != DBNull.Value)
                {
                    ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[idcolumname].Value);

                }
                else
                {
                    MessageBox.Show("Seçilen Satırda Geçerli Bir Id Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ID = 0;
                    temizle();
                    return;
                }
                if (dataGridView1.Columns.Contains(uruntur))
                {
                    txtutur.Text = dataGridView1.Rows[e.RowIndex].Cells[uruntur].Value.ToString() ?? string.Empty;
                }
                if (dataGridView1.Columns.Contains(urunadicolumname))
                {
                    txtuadi.Text = dataGridView1.Rows[e.RowIndex].Cells[urunadicolumname].Value.ToString() ?? string.Empty;
                }
                if (dataGridView1.Columns.Contains(urunadet))
                {
                    txtuadet.Text = dataGridView1.Rows[e.RowIndex].Cells[urunadet].Value.ToString() ?? string.Empty;
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show($"ID Formatında Bir Hata Oluştu : {ex.Message}", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID = 0;
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Oluştu : {ex.Message}", "Genel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID = 0;
                temizle();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Lütfen Düzenlemek İçin Bir Kayıt Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtuadi.Text) || string.IsNullOrWhiteSpace(txtutur.Text))
            {
                MessageBox.Show("Ürün Adı Ve Ürün Türü  Boş Bırakılmaz");
            }
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("Update Stok_tbl set ÜrünTürü=@p1,ÜrünAdi=@p2,ÜrünAdeti=@p3 where StokID=@ID",con))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@p1", txtutur.Text);
                        cmd.Parameters.AddWithValue("@p2", txtuadi.Text);
                        cmd.Parameters.AddWithValue("@p3", txtuadet.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    verileritazele();
                    MessageBox.Show("Ürün Başarılı Bir Şekilde Güncellendi");
                    temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabanında Bir Hata Oluştu: {ex.Message}","SQL Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (ID ==0)
            {
                MessageBox.Show("Lütfen Silmek İçin Bir Kayıt Seçiniz");
                return;
            }
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    using (SqlCommand cmd =new SqlCommand("Delete From Stok_tbl Where StokID=@ID",con))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    verileritazele();
                    MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi");
                    temizle();
                    ID = 0;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Kayıt Silinirken Bir Hata Oluştu : {ex.Message}","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    string query = "select * from Stok_tbl where ÜrünAdi Like @ara";

                    using (SqlDataAdapter adpara = new SqlDataAdapter(query, con))
                    {
                        adpara.SelectCommand.Parameters.AddWithValue("@ara", txtara.Text);
                        adpara.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama İşlemi Sırasında Bir Hata Oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verileritazele();
            temizle();
            ID = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verileritazele();
            txtara.Clear();
        }
    }
}
