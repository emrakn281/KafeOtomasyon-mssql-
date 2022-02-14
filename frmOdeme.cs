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
    public partial class frmOdeme : Form
    {
        public frmOdeme()
        {
            InitializeComponent();
        }
        public static string masaNum;
        SqlConnection baglanti = new SqlConnection("Data Source=EMRE\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        SqlConnection baglanti2 = new SqlConnection("Data Source=EMRE\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");

        public static string toplamFiyat;
        private void frmOdeme_Load(object sender, EventArgs e)

        {
            timer.Start();
            txtIndirim.Text = "0";
            lblMasaNum.Text = masaNum;
            lblKullanici.Text = personel.personelid;
            this.BackgroundImage = clsArkaplan.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            txtAraToplam.Text = toplamFiyat + " TL";
            txtToplamTutar.Text = (Convert.ToDouble(toplamFiyat)-Convert.ToDouble(txtIndirim.Text)).ToString() + " TL";
            

            SqlCommand siparisListele = new SqlCommand("SELECT * FROM siparisler WHERE MASAID=@no", baglanti2);
            siparisListele.Parameters.AddWithValue("@no", Convert.ToInt32(lblMasaNum.Text));
            baglanti2.Open();
            SqlDataReader sreader = siparisListele.ExecuteReader();

            while (sreader.Read())
            {
                ListViewItem lv = new ListViewItem(sreader[0].ToString());
                lv.SubItems.Add(sreader[2].ToString());
                lv.SubItems.Add(sreader[3].ToString());
                lv.SubItems.Add(sreader[4].ToString());
                lstSiparisler.Items.Add(lv);
            }
            baglanti2.Close();
            cmbOdemeTuru.SelectedIndex = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnOdemeIptal_Click(object sender, EventArgs e)
        {

            frmSiparis.masaNum = lblMasaNum.Text;
            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
        }

        private void txtIndirim_TextChanged(object sender, EventArgs e)
        {
            if (txtIndirim.Text == "")
                txtToplamTutar.Text = Convert.ToDouble(toplamFiyat).ToString() + " TL";
            else
            {
                if (Convert.ToDouble(txtIndirim.Text) < (Convert.ToDouble(toplamFiyat)))
                {
                    txtToplamTutar.Text = (Convert.ToDouble(toplamFiyat) - Convert.ToDouble(txtIndirim.Text)).ToString() + " TL";
                }
                else
                {
                    MessageBox.Show("İndirim Ara Toplamdan Fazla Olamaz.");
                    txtIndirim.Text = "";
                }
                    
            }

        }

        private void txtIndirim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!=',')
            {
                MessageBox.Show("İndirim Yalnızca Sayı Olabilir.", "HATA!!!");
            }
        }

        private void btnOdemeOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(toplamFiyat) > 0)
                {
                    if (cmbOdemeTuru.Text != "")
                    {
                        SqlCommand ode = new SqlCommand("INSERT INTO odeme (PERSONEL,MASA,ODEMETURU,ARATOPLAM,INDIRIM,TOPLAMTUTAR,TARIH) VALUES (@personel,@masa,@odemeturu,@aratoplam,@indirim,@toplamtutar,@tarih)", baglanti);
                        ode.Parameters.AddWithValue("@personel",lblKullanici.Text);
                        ode.Parameters.AddWithValue("@masa",Convert.ToInt32(masaNum));
                        ode.Parameters.AddWithValue("@odemeturu",cmbOdemeTuru.Text);
                        ode.Parameters.AddWithValue("@aratoplam", (Convert.ToDouble(toplamFiyat)));
                        ode.Parameters.AddWithValue("@indirim", (Convert.ToDouble(txtIndirim.Text)));
                        ode.Parameters.AddWithValue("@toplamtutar",(Convert.ToDouble(toplamFiyat) - Convert.ToDouble(txtIndirim.Text)));
                        ode.Parameters.AddWithValue("@tarih",DateTime.Now);
                        baglanti.Open();
                        ode.ExecuteNonQuery();
                        baglanti.Close();

                        SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                        masaDurum.Parameters.AddWithValue("@durum", "False");
                        masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                        baglanti2.Open();
                        masaDurum.ExecuteNonQuery();
                        baglanti2.Close();

                        MessageBox.Show("Ödeme İşlemi Gerçekleşti. Sağlıklı Günler.");

                        SqlCommand odendi = new SqlCommand("DELETE FROM siparisler WHERE MASAID = @id", baglanti);
                        odendi.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                        baglanti.Open();
                        odendi.ExecuteNonQuery();
                        baglanti.Close();

                        txtAraToplam.Text = "0";
                        txtIndirim.Text = "0";
                        txtToplamTutar.Text = "0";
                        toplamFiyat = "0";

                        lstSiparisler.Items.Clear();

                    }
                    else
                        MessageBox.Show("Ödeme Türü Seçiniz...");
                }
                else
                    MessageBox.Show("Masada Sipariş Yok...");
            }
            catch
            {
                SqlCommand ode = new SqlCommand("INSERT INTO odeme (PERSONEL,MASA,ODEMETURU,ARATOPLAM,INDIRIM,TOPLAMTUTAR,TARIH) VALUES (@personel,@masa,@odemeturu,@aratoplam,@indirim,@toplamtutar,@tarih)", baglanti);
                ode.Parameters.AddWithValue("@personel", lblKullanici.Text);
                ode.Parameters.AddWithValue("@masa", Convert.ToInt32(masaNum));
                ode.Parameters.AddWithValue("@odemeturu", cmbOdemeTuru.Text);
                ode.Parameters.AddWithValue("@aratoplam", (Convert.ToDouble(toplamFiyat)));
                ode.Parameters.AddWithValue("@indirim", 0);
                ode.Parameters.AddWithValue("@toplamtutar", (Convert.ToDouble(toplamFiyat)));
                ode.Parameters.AddWithValue("@tarih", DateTime.Now);
                baglanti.Open();
                ode.ExecuteNonQuery();
                baglanti.Close();

                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                masaDurum.Parameters.AddWithValue("@durum", "False");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti2.Open();
                masaDurum.ExecuteNonQuery();
                baglanti2.Close();

                MessageBox.Show("Ödeme İşlemi Gerçekleşti. Sağlıklı Günler.");

                SqlCommand odendi = new SqlCommand("DELETE FROM siparisler WHERE MASAID = @id", baglanti);
                odendi.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti.Open();
                odendi.ExecuteNonQuery();
                baglanti.Close();
                txtAraToplam.Text = "0";
                txtIndirim.Text = "0";
                txtToplamTutar.Text = "0";
                toplamFiyat = "0";
                lstSiparisler.Items.Clear();
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmSiparis.masaNum = lblMasaNum.Text;
            frmSiparis frm = new frmSiparis();
            this.Hide();
            frm.Show();
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

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            this.Hide();
            frm.Show();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            if(lblKullanici.Text == "admin")
            {
                frmPersoneller frm = new frmPersoneller();
                this.Hide();
                frm.Show();
            }
            else
                MessageBox.Show("Bu Alana Sadece Admin Girebilir..", "HATA!!!");
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

        private void txtIndirim_Click(object sender, EventArgs e)
        {
            txtIndirim.Text = null;
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
