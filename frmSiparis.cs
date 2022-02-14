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
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }
        
        public static string masaNum;
        SqlConnection baglanti = new SqlConnection("Data Source=EMRE\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        SqlConnection baglanti2 = new SqlConnection("Data Source=EMRE\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        public int a;
        private void frmSiparis_Load(object sender, EventArgs e)
        {
            toplamFiyat = null;
            lstSiparisler.Items.Clear();
            timer.Start();
            lblMasaNum.Text = masaNum;
            lblKullanici.Text = personel.personelid;
            this.BackgroundImage = clsArkaplan.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;

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

            lstSiparisler.Items.Clear();

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



        }

        private void btnAnaYemekler_Click(object sender, EventArgs e)
        {
            lstYemekListe.Items.Clear();
            SqlCommand listele = new SqlCommand("SELECT * FROM urunler WHERE KATEGORI='Ana Yemekler'", baglanti);
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

        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            lstYemekListe.Items.Clear();
            SqlCommand listele = new SqlCommand("SELECT * FROM urunler WHERE KATEGORI='İçecekler'", baglanti);
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

        private void btnKahvaltiliklar_Click(object sender, EventArgs e)
        {
            lstYemekListe.Items.Clear();
            SqlCommand listele = new SqlCommand("SELECT * FROM urunler WHERE KATEGORI='Kahvaltılıklar'", baglanti);
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

        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            lstYemekListe.Items.Clear();
            SqlCommand listele = new SqlCommand("SELECT * FROM urunler WHERE KATEGORI='Tatlılar'", baglanti);
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

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            if (lstSiparisler.Items.Count >= 1)
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti);
                masaDurum.Parameters.AddWithValue("@durum", "True");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti.Open();
                masaDurum.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                masaDurum.Parameters.AddWithValue("@durum", "False");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti2.Open();
                masaDurum.ExecuteNonQuery();
                baglanti2.Close();
            }
            frmMasa frm = new frmMasa();
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
                if (lstSiparisler.Items.Count >= 1)
                {
                    SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti);
                    masaDurum.Parameters.AddWithValue("@durum", "True");
                    masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                    baglanti.Open();
                    masaDurum.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                    masaDurum.Parameters.AddWithValue("@durum", "False");
                    masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                    baglanti2.Open();
                    masaDurum.ExecuteNonQuery();
                    baglanti2.Close();
                }
            }
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            if (lblKullanici.Text == "admin")
            {
                if (lstSiparisler.Items.Count >= 1)
                {
                    SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti);
                    masaDurum.Parameters.AddWithValue("@durum", "True");
                    masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                    baglanti.Open();
                    masaDurum.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                    masaDurum.Parameters.AddWithValue("@durum", "False");
                    masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                    baglanti2.Open();
                    masaDurum.ExecuteNonQuery();
                    baglanti2.Close();
                }
                frmPersoneller frm = new frmPersoneller();
                this.Hide();
                frm.Show();
            }
            else
                MessageBox.Show("Bu Alana Sadece Admin Girebilir..", "HATA!!!");
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            if (lstSiparisler.Items.Count >= 1)
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti);
                masaDurum.Parameters.AddWithValue("@durum", "True");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti.Open();
                masaDurum.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                masaDurum.Parameters.AddWithValue("@durum", "False");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti2.Open();
                masaDurum.ExecuteNonQuery();
                baglanti2.Close();
            }
            frmMasa frm = new frmMasa();
            this.Hide();
            frm.Show();
        }

        private void btnYemekMenu_Click(object sender, EventArgs e)
        {
            if (lstSiparisler.Items.Count >= 1)
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti);
                masaDurum.Parameters.AddWithValue("@durum", "True");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti.Open();
                masaDurum.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                masaDurum.Parameters.AddWithValue("@durum", "False");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti2.Open();
                masaDurum.ExecuteNonQuery();
                baglanti2.Close();
            }
            frmYemekMenu frm = new frmYemekMenu();
            this.Hide();
            frm.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            if (lstSiparisler.Items.Count >= 1)
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti);
                masaDurum.Parameters.AddWithValue("@durum", "True");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti.Open();
                masaDurum.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                masaDurum.Parameters.AddWithValue("@durum", "False");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti2.Open();
                masaDurum.ExecuteNonQuery();
                baglanti2.Close();
            }
            frmAyarlar frm = new frmAyarlar();
            this.Hide();
            frm.Show();
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            if (lstSiparisler.Items.Count >= 1)
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti);
                masaDurum.Parameters.AddWithValue("@durum", "True");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti.Open();
                masaDurum.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                masaDurum.Parameters.AddWithValue("@durum", "False");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti2.Open();
                masaDurum.ExecuteNonQuery();
                baglanti2.Close();
            }
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

        #region NUMPAD
        string numAdet = "";

        private void btnNum1_Click(object sender, EventArgs e)
        {
            numAdet += 1;
            txtNumAdet.Text = numAdet;
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            numAdet += 2;
            txtNumAdet.Text = numAdet;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            numAdet += 3;
            txtNumAdet.Text = numAdet;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            numAdet += 4;
            txtNumAdet.Text = numAdet;
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            numAdet += 5;
            txtNumAdet.Text = numAdet;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            numAdet += 6;
            txtNumAdet.Text = numAdet;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            numAdet += 7;
            txtNumAdet.Text = numAdet;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            numAdet += 8;
            txtNumAdet.Text = numAdet;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            numAdet += 9;
            txtNumAdet.Text = numAdet;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            numAdet += 0;
            txtNumAdet.Text = numAdet;
        }

        private void btnNumC_Click(object sender, EventArgs e)
        {
            txtNumAdet.Text = "";
            numAdet = txtNumAdet.Text;
        }
        #endregion

        public string ad;
        public string fiyat;
        public string adet;
        public static string satirFiyat;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                ad = lstYemekListe.SelectedItems[0].SubItems[2].Text;
                fiyat = lstYemekListe.SelectedItems[0].SubItems[3].Text;
                if (txtNumAdet.Text == "0")
                {
                    MessageBox.Show("Adet 0 olamaz!!!");
                    txtNumAdet.Text = "";
                    numAdet = "";
                }
                else
                {
                    if (txtNumAdet.Text != "")
                    {
                        adet = txtNumAdet.Text;
                    }
                    else
                        adet = "1";
                    satirFiyat = (Convert.ToDouble(adet) * Convert.ToDouble(fiyat)).ToString();

                    SqlCommand siparis = new SqlCommand("INSERT INTO siparisler (MASAID,URUNADI,ADET,FIYAT) VALUES(@masaid,@urunadi,@adet,@fiyat)", baglanti);
                    siparis.Parameters.AddWithValue("@masaid", Convert.ToInt32(lblMasaNum.Text));
                    siparis.Parameters.AddWithValue("@urunadi", ad);
                    siparis.Parameters.AddWithValue("@adet", Convert.ToInt32(adet));
                    siparis.Parameters.AddWithValue("@fiyat", Convert.ToDouble(satirFiyat));
                    baglanti.Open();
                    siparis.ExecuteNonQuery();
                    baglanti.Close();

                    lstSiparisler.Items.Clear();

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
                    baglanti.Close();

                    if (lstSiparisler.Items.Count >= 1)
                    {
                        SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti);
                        masaDurum.Parameters.AddWithValue("@durum", "True");
                        masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                        baglanti.Open();
                        masaDurum.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                        masaDurum.Parameters.AddWithValue("@durum", "False");
                        masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                        baglanti2.Open();
                        masaDurum.ExecuteNonQuery();
                        baglanti2.Close();
                    }
                    txtNumAdet.Text = "";
                    numAdet = "";

                }
            }
            catch
            {
                MessageBox.Show("Yemek Listesinden Eklenecek Ürünü Ve Aşağıdan Adeti Seçiniz...");
            }
        }
        public static double toplam = 0;
        public static double[] topla;
        public static string toplamFiyat;

        private void timer_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.ToString("dd/MM/yyyy");
            toplam = 0;
            topla = new double[lstSiparisler.Items.Count];

            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {

                topla[i] = Convert.ToDouble(lstSiparisler.Items[i].SubItems[3].Text);

                toplam = toplam + topla[i];

            }

            toplamFiyat = Convert.ToString(toplam);
            lblToplamTutar.Text = (toplamFiyat + " TL");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand siparisSil = new SqlCommand("DELETE FROM siparisler WHERE ID=@id", baglanti);
                siparisSil.Parameters.AddWithValue("@id",Convert.ToInt32(lstSiparisler.SelectedItems[0].Text));
                baglanti.Open();
                siparisSil.ExecuteNonQuery();
                baglanti.Close();

                lstSiparisler.Items.Clear();

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
                baglanti.Close();

                if (lstSiparisler.Items.Count >= 1)
                {
                    SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti);
                    masaDurum.Parameters.AddWithValue("@durum", "True");
                    masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                    baglanti.Open();
                    masaDurum.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                    masaDurum.Parameters.AddWithValue("@durum", "False");
                    masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                    baglanti2.Open();
                    masaDurum.ExecuteNonQuery();
                    baglanti2.Close();
                }


            }
            catch
            {
                MessageBox.Show("Sipariş Listesinden Silinecek Ürünü Seçiniz...");

            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (lstSiparisler.Items.Count >= 1)
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti);
                masaDurum.Parameters.AddWithValue("@durum", "True");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti.Open();
                masaDurum.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                masaDurum.Parameters.AddWithValue("@durum", "False");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti2.Open();
                masaDurum.ExecuteNonQuery();
                baglanti2.Close();
            }

            frmAnaMenu frm = new frmAnaMenu();
            this.Hide();
            frm.Show();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if (lstSiparisler.Items.Count >= 1)
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti);
                masaDurum.Parameters.AddWithValue("@durum", "True");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti.Open();
                masaDurum.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                masaDurum.Parameters.AddWithValue("@durum", "False");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti2.Open();
                masaDurum.ExecuteNonQuery();
                baglanti2.Close();
            }

            if (Convert.ToDouble(toplamFiyat)!=0)
            {
                frmOdeme.toplamFiyat = toplamFiyat;
                frmOdeme frm = new frmOdeme();
                this.Hide();
                frm.Show();
            }
            else
                MessageBox.Show("Ödenecek Tutar Bulunamadı.");



        }

        private void btnMasaKapat_Click(object sender, EventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Masayı Kapatmak İstiyor musunuz?", "MASA KAPAT", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                SqlCommand siparisSil = new SqlCommand("DELETE FROM siparisler WHERE MASAID=@id", baglanti);
                siparisSil.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti.Open();
                siparisSil.ExecuteNonQuery();
                baglanti.Close();
                lstSiparisler.Items.Clear();
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

        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            SqlCommand siparis = new SqlCommand("INSERT INTO siparisler (MASAID,URUNADI,FIYAT) VALUES(@masaid,@urunadi,@fiyat)", baglanti);
            siparis.Parameters.AddWithValue("@masaid", Convert.ToInt32(lblMasaNum.Text));
            siparis.Parameters.AddWithValue("@urunadi", "MASA DOLU");
            siparis.Parameters.AddWithValue("@fiyat", 0);
            baglanti.Open();
            siparis.ExecuteNonQuery();
            baglanti.Close();

            lstSiparisler.Items.Clear();

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
            baglanti.Close();

            if (lstSiparisler.Items.Count >= 1)
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti);
                masaDurum.Parameters.AddWithValue("@durum", "True");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti.Open();
                masaDurum.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                SqlCommand masaDurum = new SqlCommand("UPDATE masalar SET DURUM=@durum WHERE ID=@id", baglanti2);
                masaDurum.Parameters.AddWithValue("@durum", "False");
                masaDurum.Parameters.AddWithValue("@id", Convert.ToInt32(lblMasaNum.Text));
                baglanti2.Open();
                masaDurum.ExecuteNonQuery();
                baglanti2.Close();
            }
            txtNumAdet.Text = "";
            numAdet = "";
        }
    }
}
