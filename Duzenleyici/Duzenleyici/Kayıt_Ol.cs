using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Security.Policy;

namespace Duzenleyici
{
    public partial class Kayıt_Ol : Form
    {
        public Kayıt_Ol()
        {
            InitializeComponent();
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
            txtsifre.Clear();
        }
        private void btnkayıt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtkuladi.Text) || string.IsNullOrWhiteSpace(txtsifre.Text) || string.IsNullOrWhiteSpace(cmbxkulstatu.Text))
                {
                    MessageBox.Show("Lütfen Bilgileri Eksiksiz Bir Şekilde Doldurunuz");
                    return;
                }
                string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection con = new SqlConnection(bağlantı))
                {
                    string Kullanicistatusu = cmbxkulstatu.Text;
                    string Kullaniciadi = txtkuladi.Text;
                    string hashlenmisSifre = HashSifre(txtsifre.Text);

                    con.Open();
                    string query = "insert into Login_tbl(Kullanicistatusu,KullaniciAdi,Sifre) Values(@p1,@p2,@p3)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@p1", Kullanicistatusu);
                        cmd.Parameters.AddWithValue("@p2", Kullaniciadi);
                        cmd.Parameters.AddWithValue("@p3", hashlenmisSifre);
                        cmd.ExecuteNonQuery();
                    }
                    Temizle();
                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Eklendi");
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show($"Veritabanında Bir Hata Oluştu : {ex1.Message}", "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
