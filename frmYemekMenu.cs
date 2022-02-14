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
    public partial class frmYemekMenu : Form
    {
        public frmYemekMenu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EMRE\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        private void frmYemekMenu_Load(object sender, EventArgs e)
        {

            cmbSirala.SelectedIndex = 0;

            this.BackgroundImage = clsArkaplan.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            lblKullanici.Text = personel.personelid;
            timer.Start();
            SqlCommand listele = new SqlCommand("SELECT * FROM urunler ORDER BY KATEGORI", baglanti);
            baglanti.Open();
            SqlDataReader reader = listele.ExecuteReader();

            while(reader.Read())
            {
                int i = lstYemekListe.Items.Count;
                lstYemekListe.Items.Add(reader["ID"].ToString());
                lstYemekListe.Items[i].SubItems.Add(reader["KATEGORI"].ToString());
                lstYemekListe.Items[i].SubItems.Add(reader["URUNAD"].ToString());
                lstYemekListe.Items[i].SubItems.Add(reader["FIYAT"].ToString());
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

        private void btnYeniYemek_Click(object sender, EventArgs e)
        {
            if ((txtYeniYemekFiyat.Text == "") || (txtYeniYemekAdi.Text == "") || (cmbYeniYemekKategori.Text == ""))
            {
                MessageBox.Show("Boş Yer Olmamalıdır", "HATA!!!");
            }
            else
            {
                SqlCommand urunEkle = new SqlCommand("INSERT INTO urunler (KATEGORI,URUNAD,FIYAT) VALUES(@kategori,@urunad,@fiyat)", baglanti);
                urunEkle.Parameters.AddWithValue("@kategori", cmbYeniYemekKategori.Text);
                urunEkle.Parameters.AddWithValue("@urunad", txtYeniYemekAdi.Text);
                urunEkle.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtYeniYemekFiyat.Text));

                DialogResult uyari = MessageBox.Show("Ürünü Eklemek İstiyor musunuz?", "ÜRÜNÜ EKLE", MessageBoxButtons.YesNo);
                if (uyari == DialogResult.Yes)
                {
                    baglanti.Open();
                urunEkle.ExecuteNonQuery();
                baglanti.Close();

                lstYemekListe.Items.Clear();

                    SqlCommand listele = new SqlCommand("SELECT * FROM urunler ORDER BY KATEGORI", baglanti);
                    baglanti.Open();
                    SqlDataReader reader = listele.ExecuteReader();

                    while (reader.Read())
                    {
                        int i = lstYemekListe.Items.Count;
                        lstYemekListe.Items.Add(reader["ID"].ToString());
                        lstYemekListe.Items[i].SubItems.Add(reader["KATEGORI"].ToString());
                        lstYemekListe.Items[i].SubItems.Add(reader["URUNAD"].ToString());
                        lstYemekListe.Items[i].SubItems.Add(reader["FIYAT"].ToString());
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Ürün Ekleme İşlemi İptal Olmuştur.");
                }
            }

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnYemekSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand urunSil = new SqlCommand("DELETE FROM urunler WHERE ID=@id", baglanti);
                urunSil.Parameters.AddWithValue("@id", Convert.ToInt32(lstYemekListe.SelectedItems[0].SubItems[0].Text));

                DialogResult uyari = MessageBox.Show("Ürünü Silmek İstiyor musunuz?", "ÜRÜNÜ SİL", MessageBoxButtons.YesNo);
                if (uyari == DialogResult.Yes)
                {
                    baglanti.Open();
                    urunSil.ExecuteNonQuery();
                    baglanti.Close();

                    lstYemekListe.Items.Clear();

                    SqlCommand listele = new SqlCommand("SELECT * FROM urunler ORDER BY KATEGORI", baglanti);
                    baglanti.Open();
                    SqlDataReader reader = listele.ExecuteReader();

                    while (reader.Read())
                    {
                        int i = lstYemekListe.Items.Count;
                        lstYemekListe.Items.Add(reader["ID"].ToString());
                        lstYemekListe.Items[i].SubItems.Add(reader["KATEGORI"].ToString());
                        lstYemekListe.Items[i].SubItems.Add(reader["URUNAD"].ToString());
                        lstYemekListe.Items[i].SubItems.Add(reader["FIYAT"].ToString());
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Ürün Silme İşlemi İptal Olmuştur.");
                }

                

            }
            catch
            {
                MessageBox.Show("Silinecek Ürünü Seçiniz...");
            }
        }

        private void txtYeniYemekFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Fiyat Yalnızca Sayı Olabilir.", "HATA!!!");
            }
        }

        private void lstYemekListe_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                cmbYeniYemekKategori.Text = lstYemekListe.SelectedItems[0].SubItems[1].Text;
                txtYeniYemekAdi.Text = lstYemekListe.SelectedItems[0].SubItems[2].Text;
                txtYeniYemekFiyat.Text = lstYemekListe.SelectedItems[0].SubItems[3].Text;
            }
            catch
            {
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand guncelle = new SqlCommand("UPDATE urunler SET KATEGORI=@kategori, URUNAD=@urunad, FIYAT=@fiyat WHERE ID=@id", baglanti);
                guncelle.Parameters.AddWithValue("@id", Convert.ToDouble(lstYemekListe.SelectedItems[0].Text));
                guncelle.Parameters.AddWithValue("@kategori", cmbYeniYemekKategori.Text);
                guncelle.Parameters.AddWithValue("@urunad", txtYeniYemekAdi.Text);
                guncelle.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtYeniYemekFiyat.Text));

                DialogResult uyari = MessageBox.Show("Ürünü Güncellemek İstiyor musunuz?", "ÜRÜNÜ GÜNCELLE", MessageBoxButtons.YesNo);
                if (uyari == DialogResult.Yes)
                {
                    baglanti.Open();
                    guncelle.ExecuteNonQuery();
                    baglanti.Close();

                    lstYemekListe.Items.Clear();

                    SqlCommand listele = new SqlCommand("SELECT * FROM urunler ORDER BY KATEGORI", baglanti);
                    baglanti.Open();
                    SqlDataReader reader = listele.ExecuteReader();

                    while (reader.Read())
                    {
                        int i = lstYemekListe.Items.Count;
                        lstYemekListe.Items.Add(reader["ID"].ToString());
                        lstYemekListe.Items[i].SubItems.Add(reader["KATEGORI"].ToString());
                        lstYemekListe.Items[i].SubItems.Add(reader["URUNAD"].ToString());
                        lstYemekListe.Items[i].SubItems.Add(reader["FIYAT"].ToString());
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Ürün Güncelleme İşlemi İptal Olmuştur.");
                }
            }
            catch
            {
                MessageBox.Show("Güncellenecek Ürünü Seçiniz...");
            }
            
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            cmbYeniYemekKategori.Text= null;
            txtYeniYemekAdi.Text = "";
            txtYeniYemekFiyat.Text = "";
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmAnaMenu frm = new frmAnaMenu();
            this.Hide();
            frm.Show();
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

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            this.Hide();
            frm.Show();
        }

        private void btnYemekMenu_Click(object sender, EventArgs e)
        {
            frmYemekMenu frm = new frmYemekMenu();
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

        private void btnYemekListe_Click(object sender, EventArgs e)
        {
            lstYemekListe.Items.Clear();
            SqlCommand hlistele = new SqlCommand("SELECT * FROM urunler WHERE KATEGORI=@ktgr", baglanti);
            hlistele.Parameters.AddWithValue("@ktgr", cmbSirala.Text);
            baglanti.Open();
            SqlDataReader reader = hlistele.ExecuteReader();

            while (reader.Read())
            {
                int i = lstYemekListe.Items.Count;
                lstYemekListe.Items.Add(reader["ID"].ToString());
                lstYemekListe.Items[i].SubItems.Add(reader["KATEGORI"].ToString());
                lstYemekListe.Items[i].SubItems.Add(reader["URUNAD"].ToString());
                lstYemekListe.Items[i].SubItems.Add(reader["FIYAT"].ToString());
            }
            baglanti.Close();
        }

        private void btnTumuListele_Click(object sender, EventArgs e)
        {
            lstYemekListe.Items.Clear();
            SqlCommand listele = new SqlCommand("SELECT * FROM urunler ORDER BY KATEGORI", baglanti);
            baglanti.Open();
            SqlDataReader reader = listele.ExecuteReader();

            while (reader.Read())
            {
                int i = lstYemekListe.Items.Count;
                lstYemekListe.Items.Add(reader["ID"].ToString());
                lstYemekListe.Items[i].SubItems.Add(reader["KATEGORI"].ToString());
                lstYemekListe.Items[i].SubItems.Add(reader["URUNAD"].ToString());
                lstYemekListe.Items[i].SubItems.Add(reader["FIYAT"].ToString());
            }
            baglanti.Close();
        }
    }
}
