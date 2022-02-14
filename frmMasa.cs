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

namespace ProjeFinal
{
    public partial class frmMasa : Form
    {
        public frmMasa()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection("Data Source=EMRE\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");

        private void frmMasa_Load(object sender, EventArgs e)
        {
            frmSiparis.toplamFiyat = null;
            timer.Start();
            this.BackgroundImage = clsArkaplan.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            lblKullanici.Text = personel.personelid;
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Uygulamayı Kapatmak İstiyor musunuz?", "UYGULAMA ÇIKIŞ", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                SqlCommand hareket = new SqlCommand("INSERT INTO personelhareketleri (KULLANICI,ISLEMTURU,ISLEMTARIHI) VALUES(@kullanici,@islemturu,@islemtarihi)", baglanti);
                hareket.Parameters.AddWithValue("@kullanici", lblKullanici.Text);
                hareket.Parameters.AddWithValue("@islemturu", "ÇIKIŞ");
                hareket.Parameters.AddWithValue("islemtarihi", DateTime.Now);
                baglanti.Open();
                hareket.ExecuteNonQuery();
                baglanti.Close();
                Application.Exit();
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmAnaMenu frm = new frmAnaMenu();
            this.Hide();
            frm.Show();
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            SqlCommand hareket = new SqlCommand("INSERT INTO personelhareketleri (KULLANICI,ISLEMTURU,ISLEMTARIHI) VALUES(@kullanici,@islemturu,@islemtarihi)", baglanti);
            hareket.Parameters.AddWithValue("@kullanici", lblKullanici.Text);
            hareket.Parameters.AddWithValue("@islemturu", "ÇIKIŞ");
            hareket.Parameters.AddWithValue("islemtarihi", DateTime.Now);
            baglanti.Open();
            hareket.ExecuteNonQuery();
            baglanti.Close();
            frmKilit frm = new frmKilit();
            this.Hide();
            frm.Show();
        }

        private void btnYemekMenu_Click(object sender, EventArgs e)
        {
            frmYemekMenu frm = new frmYemekMenu();
            this.Hide();
            frm.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            this.Hide();
            frm.Show();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            if (lblKullanici.Text == "admin")
            {
                frmPersoneller frm = new frmPersoneller();
                this.Hide();
                frm.Show();
            }
            else
                MessageBox.Show("Bu Alana Sadece Admin Girebilir..", "HATA!!!");
        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            frmSiparis.masaNum = "1";
            frmOdeme.masaNum = "1";
            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            frmSiparis.masaNum = "2";
            frmOdeme.masaNum = "2";

            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            frmSiparis.masaNum = "3";
            frmOdeme.masaNum = "3";

            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            frmSiparis.masaNum = "4";
            frmOdeme.masaNum = "4";

            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            frmOdeme.masaNum = "5";
            frmSiparis.masaNum = "5";
            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            frmSiparis.masaNum = "6";
            frmOdeme.masaNum = "6";

            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            frmSiparis.masaNum = "7";
            frmOdeme.masaNum = "7";

            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            frmSiparis.masaNum = "8";
            frmOdeme.masaNum = "8";

            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            frmSiparis.masaNum = "9";
            frmOdeme.masaNum = "9";

            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            frmSiparis.masaNum = "10";
            frmOdeme.masaNum = "10";

            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void btnMasa11_Click(object sender, EventArgs e)
        {
            frmSiparis.masaNum = "11";
            frmOdeme.masaNum = "11";

            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void btnMasa12_Click(object sender, EventArgs e)
        {
            frmSiparis.masaNum = "12";
            frmOdeme.masaNum = "12";

            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.ToString("dd/MM/yyyy");

            for (int i = 1; i < 13; i++)
            {
                SqlCommand masa1ar = new SqlCommand("SELECT DURUM FROM masalar where ID=" + i + "", baglanti);
                baglanti.Open();
                SqlDataReader reader = masa1ar.ExecuteReader();

                while (reader.Read())
                {
                    var d = reader["DURUM"].ToString();
                    if (d == "False")
                    {
                        if (i == 1)
                        {
                            btnMasa1.BackColor = Color.Green;
                        }
                        if (i == 2)
                        {
                            btnMasa2.BackColor = Color.Green;
                        }
                        if (i == 3)
                        {
                            btnMasa3.BackColor = Color.Green;
                        }
                        if (i == 4)
                        {
                            btnMasa4.BackColor = Color.Green;
                        }
                        if (i == 5)
                        {
                            btnMasa5.BackColor = Color.Green;
                        }
                        if (i == 6)
                        {
                            btnMasa6.BackColor = Color.Green;
                        }
                        if (i == 7)
                        {
                            btnMasa7.BackColor = Color.Green;
                        }
                        if (i == 8)
                        {
                            btnMasa8.BackColor = Color.Green;
                        }
                        if (i == 9)
                        {
                            btnMasa9.BackColor = Color.Green;
                        }
                        if (i == 10)
                        {
                            btnMasa10.BackColor = Color.Green;
                        }
                        if (i == 11)
                        {
                            btnMasa11.BackColor = Color.Green;
                        }
                        if (i == 12)
                        {
                            btnMasa12.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        if (i == 1)
                        {
                            btnMasa1.BackColor = Color.Red;
                        }
                        if (i == 2)
                        {
                            btnMasa2.BackColor = Color.Red;
                        }
                        if (i == 3)
                        {
                            btnMasa3.BackColor = Color.Red;
                        }
                        if (i == 4)
                        {
                            btnMasa4.BackColor = Color.Red;
                        }
                        if (i == 5)
                        {
                            btnMasa5.BackColor = Color.Red;
                        }
                        if (i == 6)
                        {
                            btnMasa6.BackColor = Color.Red;
                        }
                        if (i == 7)
                        {
                            btnMasa7.BackColor = Color.Red;
                        }
                        if (i == 8)
                        {
                            btnMasa8.BackColor = Color.Red;
                        }
                        if (i == 9)
                        {
                            btnMasa9.BackColor = Color.Red;
                        }
                        if (i == 10)
                        {
                            btnMasa10.BackColor = Color.Red;
                        }
                        if (i == 11)
                        {
                            btnMasa11.BackColor = Color.Red;
                        }
                        if (i == 12)
                        {
                            btnMasa12.BackColor = Color.Red;
                        }
                    }
                }
                baglanti.Close();
            }
        }

        private void lblTarih_MouseHover(object sender, EventArgs e)
        {
            lblGun.Text = DateTime.Now.DayOfWeek.ToString();
            lblGun.Visible = true;
        }

        private void lblTarih_MouseLeave(object sender, EventArgs e)
        {
            lblGun.Visible = false;
        }

        private void toolAsagi_Click(object sender, EventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Uygulamayı Alta Atmak İstiyor musunuz?", "UYGULAMA ALT", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void toolKapat_Click(object sender, EventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Uygulamayı Kapatmak İstiyor musunuz?", "UYGULAMA ÇIKIŞ", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                SqlCommand hareket = new SqlCommand("INSERT INTO personelhareketleri (KULLANICI,ISLEMTURU,ISLEMTARIHI) VALUES(@kullanici,@islemturu,@islemtarihi)", baglanti);
                hareket.Parameters.AddWithValue("@kullanici", lblKullanici.Text);
                hareket.Parameters.AddWithValue("@islemturu", "ÇIKIŞ");
                hareket.Parameters.AddWithValue("islemtarihi", DateTime.Now);
                baglanti.Open();
                hareket.ExecuteNonQuery();
                baglanti.Close();
                Application.Exit();
            }
        }

        private void toolRestart_Click(object sender, EventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Uygulamaya Reset Atmak İstiyor musunuz?", "UYGULAMA RESET", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                SqlCommand hareket = new SqlCommand("INSERT INTO personelhareketleri (KULLANICI,ISLEMTURU,ISLEMTARIHI) VALUES(@kullanici,@islemturu,@islemtarihi)", baglanti);
                hareket.Parameters.AddWithValue("@kullanici", lblKullanici.Text);
                hareket.Parameters.AddWithValue("@islemturu", "RESET");
                hareket.Parameters.AddWithValue("islemtarihi", DateTime.Now);
                baglanti.Open();
                hareket.ExecuteNonQuery();
                baglanti.Close();
                Application.Restart();
            }
        }
    }
}
