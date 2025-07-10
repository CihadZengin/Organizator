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
    public partial class Musteriler : Form
    {
        private int ID = 0;
        public Musteriler()
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
                    string query = "Select * From Musteri_tbl";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapt = new SqlDataAdapter(query, bağlantı);
                        adapt.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                if (dataGridView1.Columns.Contains("MusteriID"))
                {
                    dataGridView1.Columns["MusteriID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanında Bir Hata Oluştu : {ex.Message}", "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void temizle()
        {
            txtmadi.Clear();
            txtmsoyad.Clear();
            txtmtel.Clear();
            txtmadres.Clear();
        }
        private void Musteriler_Load(object sender, EventArgs e)
        {
            verileritazele();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtmadi.Text) || string.IsNullOrWhiteSpace(txtmsoyad.Text) || string.IsNullOrWhiteSpace(txtmtel.Text) || string.IsNullOrWhiteSpace(txtmadres.Text))
                {
                    MessageBox.Show("Lütfen Bilgileri Eksiksiz Bir Şekilde Doldurunuz");
                    return;
                }
                string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection con = new SqlConnection(bağlantı))
                {
                    con.Open();
                    string query = "insert into Musteri_tbl(MusteriAdi,MusteriSoyadi,MusteriTelNo,MusteriAdres) Values(@p1,@p2,@p3,@p4)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@p1", txtmadi.Text);
                        cmd.Parameters.AddWithValue("@p2", txtmsoyad.Text);
                        cmd.Parameters.AddWithValue("@p3", txtmtel.Text);
                        cmd.Parameters.AddWithValue("@p4", txtmadres.Text);
                        cmd.ExecuteNonQuery();
                    }
                    verileritazele();
                    MessageBox.Show("Müşteri Başarılı Bir Şekilde Eklendi");
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
                string idcolumname = "MusteriID";
                string madi = "MusteriAdi";
                string msoyad = "MusteriSoyadi";
                string mtelno = "MusteriTelNo";
                string madres = "MusteriAdres";

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
                if (dataGridView1.Columns.Contains(madi))
                {
                    txtmadi.Text = dataGridView1.Rows[e.RowIndex].Cells[madi].Value.ToString() ?? string.Empty;
                }
                if (dataGridView1.Columns.Contains(msoyad))
                {
                    txtmsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[msoyad].Value.ToString() ?? string.Empty;
                }
                if (dataGridView1.Columns.Contains(mtelno))
                {
                    txtmtel.Text = dataGridView1.Rows[e.RowIndex].Cells[mtelno].Value.ToString() ?? string.Empty;
                }
                if (dataGridView1.Columns.Contains(madres))
                {
                    txtmadres.Text = dataGridView1.Rows[e.RowIndex].Cells[madres].Value.ToString() ?? string.Empty;
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
            if (string.IsNullOrWhiteSpace(txtmadi.Text) || string.IsNullOrWhiteSpace(txtmsoyad.Text) || string.IsNullOrWhiteSpace(txtmtel.Text) || string.IsNullOrWhiteSpace(txtmadres.Text))
            {
                MessageBox.Show("Müşteri Adı,Soyadı,Telefon Numarası ve Adresi  Boş Bırakılmaz");
            }
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("Update Musteri_tbl set MusteriAdi=@p1,MusteriSoyadi=@p2,MusteriTelNo=@p3,MusteriAdres=@p4 where MusteriID=@ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@p1", txtmadi.Text);
                        cmd.Parameters.AddWithValue("@p2", txtmsoyad.Text);
                        cmd.Parameters.AddWithValue("@p3", txtmtel.Text);
                        cmd.Parameters.AddWithValue("@p4", txtmadres.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    verileritazele();
                    MessageBox.Show("Müşteri Başarılı Bir Şekilde Güncellendi");
                    temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabanında Bir Hata Oluştu: {ex.Message}", "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Lütfen Silmek İçin Bir Kayıt Seçiniz");
                return;
            }
            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("Delete From Musteri_tbl Where MusteriID=@ID", con))
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
                catch (Exception ex)
                {
                    MessageBox.Show($"Kayıt Silinirken Bir Hata Oluştu : {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string query = "select * from Musteri_tbl where MusteriAdi Like @ara or MusteriTelNo Like @ara";
                    string ara = txtara.Text;
                    using (SqlDataAdapter adpara = new SqlDataAdapter(query, con))
                    {
                        adpara.SelectCommand.Parameters.AddWithValue("@ara","%" + ara + "%");
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
