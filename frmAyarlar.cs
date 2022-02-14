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
using System.IO;

namespace ProjeFinal
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=EMRE\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            pnlSifreDegistir.Location = new Point(267, 12);
            pnlSifreDegistir.Height = 600;
            pnlSifreDegistir.Width = 625;
            pnlSifreDegistir.Visible = true;
            pnlTemaDegistir.Visible = false;
            pnlKafeBilgisi.Visible = false;

            baglanti.Open();
            SqlCommand kullanici = new SqlCommand("select (KULLANICIADI) from personeller where KULLANICIADI=@user", baglanti);
            kullanici.Parameters.AddWithValue("@user", lblKullanici.Text);
            SqlDataReader kreader;
            kreader = kullanici.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("KULLANICIADI", typeof(string));
            dt.Load(kreader);
            cmbKullanici.ValueMember = "KULLANICIADI";
            cmbKullanici.DataSource = dt;
            baglanti.Close();
        }

        private void btnTemaDegistir_Click(object sender, EventArgs e)
        {
            pnlTemaDegistir.Location = new Point(267, 12);
            pnlTemaDegistir.Height = 600;
            pnlTemaDegistir.Width = 625;
            pnlSifreDegistir.Visible = false;
            pnlTemaDegistir.Visible = true;
            pnlKafeBilgisi.Visible = false;

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

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT * FROM personeller where KULLANICIADI=@user AND PASSWORD=@pass";
            SqlCommand giris = new SqlCommand(sorgu, baglanti);
            giris.Parameters.AddWithValue("@user", cmbKullanici.Text);
            giris.Parameters.AddWithValue("@pass", txtMevcutSifre.Text);
            baglanti.Open();
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                if (txtYeniSifreGir.Text.Length == 4)
                {
                    if (txtYeniSifreGir.Text == txtYeniSifreTekrar.Text)
                    {
                        SqlCommand sifreDegistir = new SqlCommand("UPDATE personeller SET PASSWORD=@pass WHERE KULLANICIADI=@user", baglanti);
                        sifreDegistir.Parameters.AddWithValue("@user", cmbKullanici.Text);
                        sifreDegistir.Parameters.AddWithValue("@pass", txtYeniSifreGir.Text);

                        DialogResult uyari = MessageBox.Show("Şifreyi Değiştirmek İstiyor musunuz?", "Şifre Değiştir", MessageBoxButtons.YesNo);
                        if (uyari == DialogResult.Yes)
                        {
                            baglanti.Close();
                            baglanti.Open();
                            sifreDegistir.ExecuteNonQuery();
                            baglanti.Close();

                            MessageBox.Show("ŞİFRE BAŞARIYLA DEĞİŞTİRİLMİŞTİR.", "İŞLEM GERÇEKLEŞTİ");
                            SqlCommand hareket = new SqlCommand("INSERT INTO personelhareketleri (KULLANICI,ISLEMTURU,ISLEMTARIHI) VALUES(@kullanici,@islemturu,@islemtarihi)", baglanti);
                            hareket.Parameters.AddWithValue("@kullanici", lblKullanici.Text);
                            hareket.Parameters.AddWithValue("@islemturu", "ŞİFRE DEĞİŞTİRME");
                            hareket.Parameters.AddWithValue("islemtarihi", DateTime.Now);
                            baglanti.Open();
                            hareket.ExecuteNonQuery();
                            baglanti.Close();
                            cmbKullanici.Text = null;
                            txtMevcutSifre.Text = "";
                            txtYeniSifreGir.Text = "";
                            txtYeniSifreTekrar.Text = "";
                            pnlSifreDegistir.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Şifre Değiştirme İşlemi İptal Olmuştur");
                            baglanti.Close();
                        }
                        }
                    else
                    {
                        MessageBox.Show("ŞİFRELER EŞLEŞMİYOR.", "HATA!!!");
                        baglanti.Close();

                    }

                }
                else
                {
                    MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
                    baglanti.Close();
                }
            }
            else
            {
                    baglanti.Close();
                    MessageBox.Show("Kullanıcı Adı ve Mevcut Şifre Eşleşmiyor.");
            }
            }
            catch
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ VE ŞİFRELERİNİZİ 4 HANELİ YAPINIZ");
            }
        }

        private void txtYeniSifreGir_TextChanged(object sender, EventArgs e)
        {
            if (txtYeniSifreGir.Text.Length > 4)
            {
                txtYeniSifreGir.Text = txtYeniSifreGir.Text.Substring(0, txtYeniSifreGir.Text.Length - 1);
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void txtMevcutSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtMevcutSifre.Text.Length > 4)
            {
                txtMevcutSifre.Text = txtMevcutSifre.Text.Substring(0, txtMevcutSifre.Text.Length - 1);
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void txtYeniSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            if (txtYeniSifreTekrar.Text.Length > 4)
            {
                txtYeniSifreTekrar.Text = txtYeniSifreTekrar.Text.Substring(0, txtYeniSifreTekrar.Text.Length - 1);
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            cmbKullanici.Text = null;
            txtMevcutSifre.Text = "";
            txtYeniSifreGir.Text = "";
            txtYeniSifreTekrar.Text = "";
        }

        private void txtMevcutSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Şifre Yalnızca Sayı Olabilir.", "HATA!!!");
            }
        }

        private void txtYeniSifreGir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Şifre Yalnızca Sayı Olabilir.", "HATA!!!");
            }
        }

        private void txtYeniSifreTekrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Şifre Yalnızca Sayı Olabilir.", "HATA!!!");
            }
        }

        private void btnVisibility1_MouseHover(object sender, EventArgs e)
        {
            txtMevcutSifre.PasswordChar = '\0';
        }

        private void btnVisibility1_MouseLeave(object sender, EventArgs e)
        {
            txtMevcutSifre.PasswordChar = '*';

        }

        private void btnVisibility2_MouseHover(object sender, EventArgs e)
        {
            txtYeniSifreGir.PasswordChar = '\0';

        }

        private void btnVisibility2_MouseLeave(object sender, EventArgs e)
        {
            txtYeniSifreGir.PasswordChar = '*';

        }

        private void btnVisibility3_MouseHover(object sender, EventArgs e)
        {
            txtYeniSifreTekrar.PasswordChar = '\0';

        }

        private void btnVisibility3_MouseLeave(object sender, EventArgs e)
        {
            txtYeniSifreTekrar.PasswordChar = '*';
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmAnaMenu frm = new frmAnaMenu();
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

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            timer.Start();
            this.BackgroundImage = clsArkaplan.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            lblKullanici.Text = personel.personelid;
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
        clsArkaplan cls = new clsArkaplan();
        private void btnTema1_Click(object sender, EventArgs e)
        {
            SqlCommand degistir = new SqlCommand("UPDATE arkaplan SET IMAGE=@image WHERE ID='1'", baglanti);
            degistir.Parameters.AddWithValue("@image", "1");
            baglanti.Open();
            degistir.ExecuteNonQuery();
            baglanti.Close();
            cls.arkaplan();
            this.BackgroundImage = clsArkaplan.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnTema2_Click(object sender, EventArgs e)
        {
            SqlCommand degistir = new SqlCommand("UPDATE arkaplan SET IMAGE=@image WHERE ID='1'", baglanti);
            degistir.Parameters.AddWithValue("@image", "2");
            baglanti.Open();
            degistir.ExecuteNonQuery();
            baglanti.Close();
            cls.arkaplan();
            this.BackgroundImage = clsArkaplan.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void btnTema3_Click(object sender, EventArgs e)
        {
            SqlCommand degistir = new SqlCommand("UPDATE arkaplan SET IMAGE=@image WHERE ID='1'", baglanti);
            degistir.Parameters.AddWithValue("@image", "3");
            baglanti.Open();
            degistir.ExecuteNonQuery();
            baglanti.Close();
            cls.arkaplan();
            this.BackgroundImage = clsArkaplan.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnTema4_Click(object sender, EventArgs e)
        {
            SqlCommand degistir = new SqlCommand("UPDATE arkaplan SET IMAGE=@image WHERE ID='1'", baglanti);
            degistir.Parameters.AddWithValue("@image", "4");
            baglanti.Open();
            degistir.ExecuteNonQuery();
            baglanti.Close();
            cls.arkaplan();
            this.BackgroundImage = clsArkaplan.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnTema5_Click(object sender, EventArgs e)
        {
            SqlCommand degistir = new SqlCommand("UPDATE arkaplan SET IMAGE=@image WHERE ID='1'", baglanti);
            degistir.Parameters.AddWithValue("@image", "5");
            baglanti.Open();
            degistir.ExecuteNonQuery();
            baglanti.Close();
            cls.arkaplan();
            this.BackgroundImage = clsArkaplan.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            frmMasa frm = new frmMasa();
            this.Hide();
            frm.Show();
        }

        private void btnYemekMenu_Click(object sender, EventArgs e)
        {
            frmYemekMenu frm = new frmYemekMenu();
            this.Hide();
            frm.Show();
        }

        private void btnKafeBilgi_Click(object sender, EventArgs e)
        {
            pnlKafeBilgisi.Location = new Point(267, 12);
            pnlKafeBilgisi.Height = 600;
            pnlKafeBilgisi.Width = 625;
            pnlKafeBilgisi.Visible = true;
            pnlSifreDegistir.Visible = false;
            pnlTemaDegistir.Visible = false;
            baglanti.Open();

            SqlCommand cek = new SqlCommand("SELECT KAFEADI,KAFETEL,KAFEADRES FROM kafebilgi WHERE ID='1' ",baglanti);
            SqlDataReader rd = cek.ExecuteReader();
            while (rd.Read())
            {
                txtKafeAdi.Text = rd["KAFEADI"].ToString();
                txtKafeTel.Text = rd["KAFETEL"].ToString();
                txtKafeAdres.Text = rd["KAFEADRES"].ToString();
            }
            baglanti.Close();


        }

        private void btnBilgiIptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cek = new SqlCommand("SELECT KAFEADI,KAFETEL,KAFEADRES FROM kafebilgi WHERE ID='1' ", baglanti);
            SqlDataReader rd = cek.ExecuteReader();
            while (rd.Read())
            {
                txtKafeAdi.Text = rd["KAFEADI"].ToString();
                txtKafeTel.Text = rd["KAFETEL"].ToString();
                txtKafeAdres.Text = rd["KAFEADRES"].ToString();
            }
            baglanti.Close();
        }

        private void btnBilgiGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("UPDATE kafebilgi SET KAFEADI=@kafeadi,KAFETEL=@kafetel,KAFEADRES=@kafeadres WHERE ID='1'", baglanti);
            guncelle.Parameters.AddWithValue("@kafeadi", txtKafeAdi.Text);
            guncelle.Parameters.AddWithValue("@kafetel", txtKafeTel.Text);
            guncelle.Parameters.AddWithValue("@kafeadres", txtKafeAdres.Text);
            DialogResult uyari = MessageBox.Show("Kafe Bilgisini Güncellemek İstiyor musunuz?", "UYARI!!!", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                baglanti.Open();
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İşlem Tamamlandı");

                txtKafeAdi.Text = "";
                txtKafeTel.Text = "";
                txtKafeAdres.Text="";
                baglanti.Open();
                SqlCommand cek = new SqlCommand("SELECT KAFEADI,KAFETEL,KAFEADRES FROM kafebilgi WHERE ID='1' ", baglanti);
                SqlDataReader rd = cek.ExecuteReader();
                while (rd.Read())
                {
                    txtKafeAdi.Text = rd["KAFEADI"].ToString();
                    txtKafeTel.Text = rd["KAFETEL"].ToString();
                    txtKafeAdres.Text = rd["KAFEADRES"].ToString();
                }
                baglanti.Close();

                SqlCommand hareket = new SqlCommand("INSERT INTO personelhareketleri (KULLANICI,ISLEMTURU,ISLEMTARIHI) VALUES(@kullanici,@islemturu,@islemtarihi)", baglanti);
                hareket.Parameters.AddWithValue("@kullanici", lblKullanici.Text);
                hareket.Parameters.AddWithValue("@islemturu", "BİLGİ GÜNCELLEME");
                hareket.Parameters.AddWithValue("islemtarihi", DateTime.Now);
                baglanti.Open();
                hareket.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("İşlem İptal Olmuştur.");
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
