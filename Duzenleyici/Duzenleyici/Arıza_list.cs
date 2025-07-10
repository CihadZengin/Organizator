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
    public partial class Arıza_list : Form
    {
        public Arıza_list()
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
                    string query = "select Tarihler,MusteriAdi,MusteriSoyadi,MusteriTelNo,MusteriAdres,ArizaNot from Ariza_tbl\r\ninner join Musteri_tbl on MusteriID=AMusteriID\r\ninner join Tarih_tbl on TarihID=ArizaTarihiID\r\norder by Tarihler desc";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapt = new SqlDataAdapter(query, bağlantı);
                        adapt.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanında Bir Hata Oluştu : {ex.Message}", "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Arıza_list_Load(object sender, EventArgs e)
        {
            verileritazele();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            try
            {
                string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection con = new SqlConnection(bağlantı))
                {
                    DataTable dt = new DataTable();
                    string query = "select Tarihler,MusteriAdi,MusteriSoyadi,MusteriTelNo,MusteriAdres,ArizaNot from Ariza_tbl\r\ninner join Musteri_tbl on MusteriID=AMusteriID\r\ninner join Tarih_tbl on TarihID=ArizaTarihiID\r\n Where MusteriAdi Like @ara or MusteriTelNo Like @ara order by Tarihler desc";
                    string ara = txtara.Text;
                    using (SqlDataAdapter adpara = new SqlDataAdapter(query, con))
                    {
                        adpara.SelectCommand.Parameters.AddWithValue("@ara", "%" + ara + "%");
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection con = new SqlConnection(bağlantı))
                {
                    DataTable dt = new DataTable();
                    string query = "select Tarihler,MusteriAdi,MusteriSoyadi,MusteriTelNo,MusteriAdres,ArizaNot from Ariza_tbl\r\ninner join Musteri_tbl on MusteriID=AMusteriID\r\ninner join Tarih_tbl on TarihID=ArizaTarihiID where Tarihler Like @ara order by Tarihler desc";
                    string secilenTarih = date.Value.ToString("dd-MM-yyyy");
                    using (SqlDataAdapter adpara = new SqlDataAdapter(query, con))
                    {
                        adpara.SelectCommand.Parameters.AddWithValue("@ara", "%" + secilenTarih + "%");
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

        private void button4_Click(object sender, EventArgs e)
        {
            date.Value = DateTime.Today;
            verileritazele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verileritazele();
            txtara.Clear();
        }
    }
}
