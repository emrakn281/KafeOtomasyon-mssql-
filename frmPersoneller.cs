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
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EMRE\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");

        private void lstPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtAdi.Text = lstPersoneller.SelectedItems[0].SubItems[1].Text;
                txtSoyadi.Text = lstPersoneller.SelectedItems[0].SubItems[2].Text;
                txtKullaniciAdi.Text = lstPersoneller.SelectedItems[0].SubItems[3].Text;
                txtSifre.Text = lstPersoneller.SelectedItems[0].SubItems[4].Text;

            }
            catch
            {
            }
        }

        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kullanici = new SqlCommand("select (KULLANICIADI) from personeller", baglanti);
            SqlDataReader kreader;
            kreader = kullanici.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("KULLANICIADI", typeof(string));
            dt.Load(kreader);
            cmbKullanici.ValueMember = "KULLANICIADI";
            cmbKullanici.DataSource = dt;
            baglanti.Close();

            cmbKullanici.SelectedIndex = 0;

            cmbListele.SelectedIndex = 0;
            timer.Start();
            this.BackgroundImage = clsArkaplan.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            lblKullanici.Text = personel.personelid;
            lstPersoneller.Items.Clear();
            SqlCommand listele = new SqlCommand("SELECT * FROM personeller ORDER BY ID", baglanti);
            baglanti.Open();
            SqlDataReader reader = listele.ExecuteReader();

            while (reader.Read())
            {
                int i = lstPersoneller.Items.Count;
                lstPersoneller.Items.Add(reader["ID"].ToString());
                lstPersoneller.Items[i].SubItems.Add(reader["AD"].ToString());
                lstPersoneller.Items[i].SubItems.Add(reader["SOYAD"].ToString());
                lstPersoneller.Items[i].SubItems.Add(reader["KULLANICIADI"].ToString());
                lstPersoneller.Items[i].SubItems.Add(reader["PASSWORD"].ToString());

            }
            baglanti.Close();

            lstHareketler.Items.Clear();
            SqlCommand hlistele = new SqlCommand("SELECT * FROM personelhareketleri ORDER BY ID desc", baglanti);
            baglanti.Open();
            SqlDataReader hreader = hlistele.ExecuteReader();

            while (hreader.Read())
            {
                int i = lstHareketler.Items.Count;
                lstHareketler.Items.Add(hreader["ID"].ToString());
                lstHareketler.Items[i].SubItems.Add(hreader["KULLANICI"].ToString());
                lstHareketler.Items[i].SubItems.Add(hreader["ISLEMTURU"].ToString());
                lstHareketler.Items[i].SubItems.Add(hreader["ISLEMTARIHI"].ToString());
            }
            baglanti.Close();

            lstRapor.Items.Clear();
            SqlCommand olistele = new SqlCommand("SELECT * FROM odeme ORDER BY ID desc", baglanti);
            baglanti.Open();
            SqlDataReader oreader = olistele.ExecuteReader();

            while (oreader.Read())
            {
                int i = lstRapor.Items.Count;
                lstRapor.Items.Add(oreader["ID"].ToString());
                lstRapor.Items[i].SubItems.Add(oreader["PERSONEL"].ToString());
                lstRapor.Items[i].SubItems.Add(oreader["MASA"].ToString());
                lstRapor.Items[i].SubItems.Add(oreader["ODEMETURU"].ToString());
                lstRapor.Items[i].SubItems.Add(oreader["ARATOPLAM"].ToString());
                lstRapor.Items[i].SubItems.Add(oreader["INDIRIM"].ToString());
                lstRapor.Items[i].SubItems.Add(oreader["TOPLAMTUTAR"].ToString());
                lstRapor.Items[i].SubItems.Add(oreader["TARIH"].ToString());

            }
            baglanti.Close();
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
        private void btnYeniPersonel_Click(object sender, EventArgs e)
        {
            if ((txtAdi.Text == "") || (txtSoyadi.Text == "") || (txtKullaniciAdi.Text == "") || (txtSifre.Text == ""))
            {
                MessageBox.Show("Boş Yer Olmamalıdır", "HATA!!!");
            }
            else
            {
                SqlCommand personelEkle = new SqlCommand("INSERT INTO personeller (AD,SOYAD,KULLANICIADI,PASSWORD) VALUES(@ad,@soyad,@kullaniciadi,@pass)", baglanti);
                personelEkle.Parameters.AddWithValue("@ad", txtAdi.Text);
                personelEkle.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
                personelEkle.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
                personelEkle.Parameters.AddWithValue("@pass", txtSifre.Text);
                if (txtSifre.Text.Length == 4)
                {
                    DialogResult uyari = MessageBox.Show("Personeli Eklemek İstiyor musunuz?", "PERSONEL EKLE", MessageBoxButtons.YesNo);
                    if (uyari == DialogResult.Yes)
                    {
                        baglanti.Open();
                        personelEkle.ExecuteNonQuery();
                        baglanti.Close();

                        lstPersoneller.Items.Clear();

                        SqlCommand listele = new SqlCommand("SELECT * FROM personeller ORDER BY ID", baglanti);
                        baglanti.Open();
                        SqlDataReader reader = listele.ExecuteReader();

                        while (reader.Read())
                        {
                            int i = lstPersoneller.Items.Count;
                            lstPersoneller.Items.Add(reader["ID"].ToString());
                            lstPersoneller.Items[i].SubItems.Add(reader["AD"].ToString());
                            lstPersoneller.Items[i].SubItems.Add(reader["SOYAD"].ToString());
                            lstPersoneller.Items[i].SubItems.Add(reader["KULLANICIADI"].ToString());
                            lstPersoneller.Items[i].SubItems.Add(reader["PASSWORD"].ToString());

                        }
                        baglanti.Close();

                        MessageBox.Show("Personel Eklenmiştir.");
                        txtAdi.Text = "";
                        txtSoyadi.Text = "";
                        txtKullaniciAdi.Text = "";
                        txtSifre.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Personel Ekleme İşlemi İptal Olmuştur.");
                    }
                }
                else
                    MessageBox.Show("Şifre 4 Haneli Olmalıdır...", "HATA!!!");
                

                
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Şifre Yalnızca Sayı Olabilir.", "HATA!!!");
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text.Length > 4)
            {
                txtSifre.Text = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand personelGuncelle = new SqlCommand("UPDATE personeller SET AD=@ad, SOYAD=@soyad, KULLANICIADI=@kullaniciadi, PASSWORD=@pass WHERE ID=@id", baglanti);
                personelGuncelle.Parameters.AddWithValue("@id", Convert.ToInt32(lstPersoneller.SelectedItems[0].Text));
                personelGuncelle.Parameters.AddWithValue("@ad", txtAdi.Text);
                personelGuncelle.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
                personelGuncelle.Parameters.AddWithValue("@kullaniciadi",txtKullaniciAdi.Text);
                personelGuncelle.Parameters.AddWithValue("@pass", txtSifre.Text);

                if (txtSifre.Text.Length == 4)
                {
                    DialogResult uyari = MessageBox.Show("Personeli Güncellemek İstiyor musunuz?", "PERSONELİ GÜNCELLE", MessageBoxButtons.YesNo);
                    if (uyari == DialogResult.Yes)
                    {
                        baglanti.Open();
                        personelGuncelle.ExecuteNonQuery();
                        baglanti.Close();

                        lstPersoneller.Items.Clear();

                        SqlCommand listele = new SqlCommand("SELECT * FROM personeller ORDER BY ID", baglanti);
                        baglanti.Open();
                        SqlDataReader reader = listele.ExecuteReader();

                        while (reader.Read())
                        {
                            int i = lstPersoneller.Items.Count;
                            lstPersoneller.Items.Add(reader["ID"].ToString());
                            lstPersoneller.Items[i].SubItems.Add(reader["AD"].ToString());
                            lstPersoneller.Items[i].SubItems.Add(reader["SOYAD"].ToString());
                            lstPersoneller.Items[i].SubItems.Add(reader["KULLANICIADI"].ToString());
                            lstPersoneller.Items[i].SubItems.Add(reader["PASSWORD"].ToString());
                        }
                        baglanti.Close();
                        MessageBox.Show("Personel Güncellenmiştir.");
                        txtAdi.Text = "";
                        txtSoyadi.Text= "";
                        txtKullaniciAdi.Text = "";
                        txtSifre.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Personel Güncelleme İşlemi İptal Olmuştur.");
                    }
                }
                else
                    MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
                
            }
            catch
            {
                MessageBox.Show("Güncellenecek Personeli Seçiniz...");
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand urunSil = new SqlCommand("DELETE FROM personeller WHERE ID=@id", baglanti);
                urunSil.Parameters.AddWithValue("@id", Convert.ToInt32(lstPersoneller.SelectedItems[0].SubItems[0].Text));

                DialogResult uyari = MessageBox.Show("Personeli Silmek İstiyor musunuz?", "PERSONEL SİL", MessageBoxButtons.YesNo);
                if (uyari == DialogResult.Yes)
                {
                    baglanti.Open();
                    urunSil.ExecuteNonQuery();
                    baglanti.Close();

                    lstPersoneller.Items.Clear();

                    SqlCommand listele = new SqlCommand("SELECT * FROM personeller ORDER BY ID", baglanti);
                    baglanti.Open();
                    SqlDataReader reader = listele.ExecuteReader();

                    while (reader.Read())
                    {
                        int i = lstPersoneller.Items.Count;
                        lstPersoneller.Items.Add(reader["ID"].ToString());
                        lstPersoneller.Items[i].SubItems.Add(reader["AD"].ToString());
                        lstPersoneller.Items[i].SubItems.Add(reader["SOYAD"].ToString());
                        lstPersoneller.Items[i].SubItems.Add(reader["KULLANICIADI"].ToString());
                        lstPersoneller.Items[i].SubItems.Add(reader["PASSWORD"].ToString());
                    }
                    baglanti.Close();
                    MessageBox.Show("Personel Silinmiştir.");
                    txtAdi.Text = "";
                    txtSoyadi.Text = "";
                    txtKullaniciAdi.Text = "";
                    txtSifre.Text = "";
                }
                else
                {
                    MessageBox.Show("Personel Silme İşlemi İptal Olmuştur.");
                }

            }
            catch 
            {
                MessageBox.Show("Silinecek Personeli Seçiniz...");
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT * FROM admin where PASS=@pass2";
                SqlCommand giris = new SqlCommand(sorgu, baglanti);
                giris.Parameters.AddWithValue("@pass2", txtMevcutSifre.Text);
                baglanti.Open();
                SqlDataReader dr = giris.ExecuteReader();
                if (dr.Read())
                {
                    if (txtYeniSifreGir.Text.Length == 4)
                    {
                        if (txtYeniSifreGir.Text == txtYeniSifreTekrar.Text)
                        {
                            SqlCommand sifreDegistir = new SqlCommand("UPDATE admin SET PASS=@pass", baglanti);
                            sifreDegistir.Parameters.AddWithValue("@pass", txtYeniSifreGir.Text);

                            DialogResult uyari = MessageBox.Show("Şifreyi Değiştirmek İstiyor musunuz?", "Şifre Değiştir", MessageBoxButtons.YesNo);
                            if (uyari == DialogResult.Yes)
                            {
                                baglanti.Close();
                                baglanti.Open();
                                sifreDegistir.ExecuteNonQuery();
                                baglanti.Close();

                                MessageBox.Show("ŞİFRE BAŞARIYLA DEĞİŞTİRİLMİŞTİR.", "İŞLEM GERÇEKLEŞTİ");
                                txtMevcutSifre.Text = "";
                                txtYeniSifreGir.Text = "";
                                txtYeniSifreTekrar.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Şifre Değiştirme İşlemi İptal Olmuştur");
                            }
                        }
                        else
                            MessageBox.Show("ŞİFRELER EŞLEŞMİYOR.", "HATA!!!");
                    }
                    else
                        MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
                }
                else
                {
                    MessageBox.Show(" Mevcut Şifre Doğru Değil.");
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

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmAnaMenu frm = new frmAnaMenu();
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

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            frmMasa frm = new frmMasa();
            this.Hide();
            frm.Show();
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

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (cmbListele.Text != "Tümü")
            {
                lstRapor.Items.Clear();
                SqlCommand olistele = new SqlCommand("SELECT * FROM odeme WHERE ODEMETURU=@tur", baglanti);
                olistele.Parameters.AddWithValue("tur", cmbListele.Text);
                baglanti.Open();
                SqlDataReader oreader = olistele.ExecuteReader();

                while (oreader.Read())
                {
                    int i = lstRapor.Items.Count;
                    lstRapor.Items.Add(oreader["ID"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["PERSONEL"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["MASA"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["ODEMETURU"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["ARATOPLAM"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["INDIRIM"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["TOPLAMTUTAR"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["TARIH"].ToString());

                }
                baglanti.Close();
            }
            else
            {
                lstRapor.Items.Clear();
                SqlCommand olistele = new SqlCommand("SELECT * FROM odeme ORDER BY ID desc", baglanti);
                baglanti.Open();
                SqlDataReader oreader = olistele.ExecuteReader();

                while (oreader.Read())
                {
                    int i = lstRapor.Items.Count;
                    lstRapor.Items.Add(oreader["ID"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["PERSONEL"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["MASA"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["ODEMETURU"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["ARATOPLAM"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["INDIRIM"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["TOPLAMTUTAR"].ToString());
                    lstRapor.Items[i].SubItems.Add(oreader["TARIH"].ToString());

                }
                baglanti.Close();
            }
            
        }

        private void btnKullaniciListe_Click(object sender, EventArgs e)
        {
            lstHareketler.Items.Clear();
            SqlCommand hlistele = new SqlCommand("SELECT * FROM personelhareketleri WHERE KULLANICI=@user", baglanti);
            hlistele.Parameters.AddWithValue("@user", cmbKullanici.Text);
            baglanti.Open();
            SqlDataReader hreader = hlistele.ExecuteReader();

            while (hreader.Read())
            {
                int i = lstHareketler.Items.Count;
                lstHareketler.Items.Add(hreader["ID"].ToString());
                lstHareketler.Items[i].SubItems.Add(hreader["KULLANICI"].ToString());
                lstHareketler.Items[i].SubItems.Add(hreader["ISLEMTURU"].ToString());
                lstHareketler.Items[i].SubItems.Add(hreader["ISLEMTARIHI"].ToString());
            }
            baglanti.Close();


        }

        private void btnTumuListele_Click(object sender, EventArgs e)
        {
            lstHareketler.Items.Clear();
            SqlCommand hlistele = new SqlCommand("SELECT * FROM personelhareketleri ORDER BY ID desc", baglanti);
            baglanti.Open();
            SqlDataReader hreader = hlistele.ExecuteReader();

            while (hreader.Read())
            {
                int i = lstHareketler.Items.Count;
                lstHareketler.Items.Add(hreader["ID"].ToString());
                lstHareketler.Items[i].SubItems.Add(hreader["KULLANICI"].ToString());
                lstHareketler.Items[i].SubItems.Add(hreader["ISLEMTURU"].ToString());
                lstHareketler.Items[i].SubItems.Add(hreader["ISLEMTARIHI"].ToString());
            }
            baglanti.Close();
        }

        private void btnTumSil_Click(object sender, EventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Tüm Personel Hareketlerini Silmek İstiyor Musunuz?", "HAREKETLERİ SİL", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("DELETE FROM personelhareketleri", baglanti);
                baglanti.Open();
                sil.ExecuteNonQuery();
                baglanti.Close();
                lstHareketler.Items.Clear();

                SqlCommand hareket = new SqlCommand("INSERT INTO personelhareketleri (KULLANICI,ISLEMTURU,ISLEMTARIHI) VALUES(@kullanici,@islemturu,@islemtarihi)", baglanti);
                hareket.Parameters.AddWithValue("@kullanici", lblKullanici.Text);
                hareket.Parameters.AddWithValue("@islemturu", "KAYITLAR SİLİNDİ");
                hareket.Parameters.AddWithValue("islemtarihi", DateTime.Now);
                baglanti.Open();
                hareket.ExecuteNonQuery();
                baglanti.Close();
                SqlCommand hlistele = new SqlCommand("SELECT * FROM personelhareketleri ORDER BY ID desc", baglanti);
                baglanti.Open();
                SqlDataReader hreader = hlistele.ExecuteReader();

                while (hreader.Read())
                {
                    int i = lstHareketler.Items.Count;
                    lstHareketler.Items.Add(hreader["ID"].ToString());
                    lstHareketler.Items[i].SubItems.Add(hreader["KULLANICI"].ToString());
                    lstHareketler.Items[i].SubItems.Add(hreader["ISLEMTURU"].ToString());
                    lstHareketler.Items[i].SubItems.Add(hreader["ISLEMTARIHI"].ToString());
                }
                baglanti.Close();
            }
        }
        string dosyaadi;
        public void exportFile(ListView lv, string splitter)
        {
            try
            {
                string filename = "";
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Title = "SaveFileDialog Export2File";
                sfd.Filter = "Text File (.txt) | *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filename = sfd.FileName.ToString();
                    dosyaadi = sfd.FileName.ToString();
                    if (filename != "")
                    {
                        using (StreamWriter sw = new StreamWriter(filename))
                        {
                            sw.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", lv.Columns[0].Text, splitter, lv.Columns[1].Text, splitter, lv.Columns[2].Text, splitter, lv.Columns[3].Text,
                                splitter);
                            foreach (ListViewItem item in lv.Items)
                            {
                                sw.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", item.SubItems[0].Text, splitter, item.SubItems[1].Text, splitter, item.SubItems[2].Text, splitter, item.SubItems[3].Text, splitter);
                            }
                            MessageBox.Show("Kayıtlar " + dosyaadi + " adlı text dosyasına kaydedilmiştir.", "KAYIT BAŞARILI");
                        }
                    }
                    else
                        MessageBox.Show("1Kayıt Aktarılırken Hata Oluştu.");
                }
            }
            catch
            {
                MessageBox.Show("Kayıt Aktarılırken Hata Oluştu.");

            }

        }
        public void export2File(ListView lv, string splitter)
        {
            try
            {
                string filename = "";
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Title = "SaveFileDialog Export2File";
                sfd.Filter = "Text File (.txt) | *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filename = sfd.FileName.ToString();
                    dosyaadi = sfd.FileName.ToString();
                    if (filename != "")
                    {
                        using (StreamWriter sw = new StreamWriter(filename))
                        {
                            sw.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}", lv.Columns[0].Text, splitter, lv.Columns[1].Text, splitter, lv.Columns[2].Text, splitter, lv.Columns[3].Text,
                                splitter, lv.Columns[4].Text, splitter, lv.Columns[5].Text, splitter, lv.Columns[6].Text, splitter,lv.Columns[7].Text, splitter);
                            foreach (ListViewItem item in lv.Items)
                            {
                                sw.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}", item.SubItems[0].Text, splitter, item.SubItems[1].Text, splitter, item.SubItems[2].Text, splitter, 
                                    item.SubItems[3].Text, splitter, item.SubItems[4].Text, splitter, item.SubItems[5].Text, splitter, item.SubItems[6].Text, splitter, item.SubItems[7].Text, splitter);
                            }
                            MessageBox.Show("Kayıtlar " + dosyaadi + " adlı text dosyasına kaydedilmiştir.", "KAYIT BAŞARILI");
                        }
                    }
                    else
                        MessageBox.Show("Kayıt Aktarılırken Hata Oluştu.");

                }
            }
            catch
            {
                MessageBox.Show("Kayıt Aktarılırken Hata Oluştu.");

            }

}
        private void btnHareketAktar_Click(object sender, EventArgs e)
        {
            try
            {
                exportFile(lstHareketler, "   |   ");
            }
            catch
            {
                MessageBox.Show("Kayıt Aktarılırken Hata Oluştu.");
            }

        }

        private void btnRaporAktar_Click(object sender, EventArgs e)
        {
            try
            {
                export2File(lstRapor, "   |   ");
            }
            catch
            {
                MessageBox.Show("Kayıt Aktarılırken Hata Oluştu.");
            }
        }
    }
}
