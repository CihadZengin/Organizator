using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duzenleyici
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panel_islemler.Width == 70)
            {
                panel_islemler.Width = 185;
            }
            else if (panel_islemler.Width ==185)
            {
                panel_islemler.Width = 70;
            }
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            panel_islemler.Width = 70;
        }
    void FormGetir(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
            form.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_kullanicilar_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanıcı = new Kullanicilar();
            kullanıcı.Show();
            FormGetir(Kullanicilar.ActiveForm, panel_formlar);
        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            Stok_Durumu stok = new Stok_Durumu();
            stok.Show();
            FormGetir(Stok_Durumu.ActiveForm, panel_formlar);
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            musteri.Show();
            FormGetir(Musteriler.ActiveForm,panel_formlar);
        }

        private void btnkayıt_Click(object sender, EventArgs e)
        {
            Kayıt k =new Kayıt();
            k.Show();
            FormGetir(Kayıt.ActiveForm,panel_formlar);
        }

        private void btn_kurulumlar_Click(object sender, EventArgs e)
        {
            Kurumlar_list kurulum = new Kurumlar_list();
            kurulum.Show();
            FormGetir(Kurumlar_list.ActiveForm,panel_formlar);
        }

        private void btn_ariza_Click(object sender, EventArgs e)
        {
            Arıza_list arıza = new Arıza_list();
            arıza.Show();
            FormGetir(Arıza_list.ActiveForm,panel_formlar);
        }
    }
}
