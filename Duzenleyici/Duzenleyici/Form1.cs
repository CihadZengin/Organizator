using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duzenleyici
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void llblkayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayıt_Ol frmk = new Kayıt_Ol();
            frmk.ShowDialog();
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
        private void temizle()
        {
            txtkuladi.Clear();
            txtsifre.Clear();
        }

        private void Btngiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkuladi.Text) || string.IsNullOrWhiteSpace(txtsifre.Text))
            {
                MessageBox.Show("Kullanıcı Adı Ve Şifre Boş Bırakılamaz","Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string KullaniciAdi = txtkuladi.Text;
            string GirilenSifre = txtsifre.Text;
            string hashlenmişGirilenSifre = HashSifre(GirilenSifre);

            string veritabanındakihash = null;

            string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
            using (SqlConnection con = new SqlConnection(bağlantı))
            {
                try
                {
                    string query = "select Sifre FROM Login_tbl Where KullaniciAdi = @p1";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@p1",KullaniciAdi);
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            veritabanındakihash = result.ToString();
                        }
                        con.Close();
                    }

                    if (veritabanındakihash != null && veritabanındakihash == hashlenmişGirilenSifre)
                    {
                        MessageBox.Show("Giriş Başarılı Güzel Bir İş Günü Dileriz", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AnaSayfa frmana = new AnaSayfa();
                        frmana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış Lütfen Tekrar Deneyiniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        temizle();
                    }
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show($"Veritabanına Bağlanırken Bir Hata Oluştu : {sqlex.Message}","SQL Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmedik Bir Hata Oluştu : {ex.Message} ","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void txtsifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtkuladi.Text) || string.IsNullOrWhiteSpace(txtsifre.Text))
                {
                    MessageBox.Show("Kullanıcı Adı Ve Şifre Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string KullaniciAdi = txtkuladi.Text;
                string GirilenSifre = txtsifre.Text;
                string hashlenmişGirilenSifre = HashSifre(GirilenSifre);

                string veritabanındakihash = null;

                string bağlantı = "Data Source=.; Initial Catalog=Duzenleyici;Integrated security=true;";
                using (SqlConnection con = new SqlConnection(bağlantı))
                {
                    try
                    {
                        string query = "select Sifre FROM Login_tbl Where KullaniciAdi = @p1";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@p1", KullaniciAdi);
                            con.Open();
                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                veritabanındakihash = result.ToString();
                            }
                            con.Close();
                        }

                        if (veritabanındakihash != null && veritabanındakihash == hashlenmişGirilenSifre)
                        {
                            MessageBox.Show("Giriş Başarılı Güzel Bir İş Günü Dileriz", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AnaSayfa frmana = new AnaSayfa();
                            frmana.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış Lütfen Tekrar Deneyiniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            temizle();
                        }
                    }
                    catch (SqlException sqlex)
                    {
                        MessageBox.Show($"Veritabanına Bağlanırken Bir Hata Oluştu : {sqlex.Message}", "SQL Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Beklenmedik Bir Hata Oluştu : {ex.Message} ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
            }
        }
    }
}
