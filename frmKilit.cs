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
    public partial class frmKilit : Form
    {
        string sifre = "";
        SqlConnection baglanti = new SqlConnection("Data Source=EMRE\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        public frmKilit()
        {
            InitializeComponent();
        }

        private void frmKilit_Load(object sender, EventArgs e)
        {
            clsArkaplan cls = new clsArkaplan();
            cls.arkaplan();

            this.BackgroundImage = clsArkaplan.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            pnlAdmin.Visible = false;
            lblAdminGirisi.Visible = false;

            foreach (Control x in this.Controls)
            {
                if ((x) is Button)
                {
                    x.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                }
            }
            timer.Start();
     
            baglanti.Open();
            SqlCommand kullanici = new SqlCommand("select (KULLANICIADI) from personeller",baglanti);
            SqlDataReader kreader;
            kreader = kullanici.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("KULLANICIADI", typeof(string));
            dt.Load(kreader);
            cmbKullanici.ValueMember = "KULLANICIADI";
            cmbKullanici.DataSource = dt;
            baglanti.Close();
        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM personeller where KULLANICIADI=@user AND PASSWORD=@pass";
            SqlCommand giris = new SqlCommand(sorgu, baglanti);
            giris.Parameters.AddWithValue("@user", cmbKullanici.Text);
            giris.Parameters.AddWithValue("@pass", txtSifre.Text);
            baglanti.Open();
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                personel.personelid = cmbKullanici.Text;
                frmAnaMenu frm = new frmAnaMenu();
                this.Hide();
                frm.Show();
                baglanti.Close();
                SqlCommand hareket = new SqlCommand("INSERT INTO personelhareketleri (KULLANICI,ISLEMTURU,ISLEMTARIHI) VALUES(@kullanici,@islemturu,@islemtarihi)", baglanti);
                hareket.Parameters.AddWithValue("@kullanici", cmbKullanici.Text);
                hareket.Parameters.AddWithValue("@islemturu", "GİRİŞ");
                hareket.Parameters.AddWithValue("islemtarihi", DateTime.Now);
                baglanti.Open();
                hareket.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Eşleşmiyor.");
                baglanti.Close();
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            sifre += "1";
            txtSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtSifre.Text = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                sifre = txtSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }

        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            sifre += "2";
            txtSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtSifre.Text = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                sifre = txtSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            sifre += "3";
            txtSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtSifre.Text = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                sifre = txtSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            sifre += "4";
            txtSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtSifre.Text = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                sifre = txtSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            sifre += "5";
            txtSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtSifre.Text = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                sifre = txtSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            sifre += "6";
            txtSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtSifre.Text = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                sifre = txtSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            sifre += "7";
            txtSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtSifre.Text = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                sifre = txtSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            sifre += "8";
            txtSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtSifre.Text = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                sifre = txtSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            sifre += "9";
            txtSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtSifre.Text = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                sifre = txtSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            sifre += "0";
            txtSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtSifre.Text = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                sifre = txtSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNumGeriAl_Click(object sender, EventArgs e)
        {

            if (sifre != "")
            {
                txtSifre.Text = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                sifre = txtSifre.Text;
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Uygulamayı Kapatmak İstiyor musunuz?", "UYGULAMA ÇIKIŞ", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNumTemizle_Click(object sender, EventArgs e)
        {
            txtSifre.Text = "";
            sifre = txtSifre.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void programcıBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Emre Akın \n 0555 444 33 22 \n Mecidiyeköy 188.Sokak No.4 ", "Programcı Bilgisi");
        }
        public string ad;
        public string tel;
        public string adres;
        private void kafeBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cek = new SqlCommand("SELECT KAFEADI,KAFETEL,KAFEADRES FROM kafebilgi WHERE ID='1' ", baglanti);
            SqlDataReader rd = cek.ExecuteReader();
            while (rd.Read())
            {
                 ad= rd["KAFEADI"].ToString();
                 tel = rd["KAFETEL"].ToString();
                 adres = rd["KAFEADRES"].ToString();   
            }
            MessageBox.Show(ad+"\n"+tel+"\n"+adres,"KAFE BİLGİSİ");
            baglanti.Close();
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
                Application.Exit();
            }
        }

        private void toolRestart_Click(object sender, EventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Uygulamaya Reset Atmak İstiyor musunuz?", "UYGULAMA RESET", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnNuma1_Click(object sender, EventArgs e)
        {
            sifre += "1";
            txtAdminSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtAdminSifre.Text = txtAdminSifre.Text.Substring(0, txtAdminSifre.Text.Length - 1);
                sifre = txtAdminSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }

        }

        private void btnNuma2_Click(object sender, EventArgs e)
        {
            sifre += "2";
            txtAdminSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtAdminSifre.Text = txtAdminSifre.Text.Substring(0, txtAdminSifre.Text.Length - 1);
                sifre = txtAdminSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNuma3_Click(object sender, EventArgs e)
        {
            sifre += "3";
            txtAdminSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtAdminSifre.Text = txtAdminSifre.Text.Substring(0, txtAdminSifre.Text.Length - 1);
                sifre = txtAdminSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNuma4_Click(object sender, EventArgs e)
        {
            sifre += "4";
            txtAdminSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtAdminSifre.Text = txtAdminSifre.Text.Substring(0, txtAdminSifre.Text.Length - 1);
                sifre = txtAdminSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNuma5_Click(object sender, EventArgs e)
        {
            sifre += "5";
            txtAdminSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtAdminSifre.Text = txtAdminSifre.Text.Substring(0, txtAdminSifre.Text.Length - 1);
                sifre = txtAdminSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNuma6_Click(object sender, EventArgs e)
        {
            sifre += "6";
            txtAdminSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtAdminSifre.Text = txtAdminSifre.Text.Substring(0, txtAdminSifre.Text.Length - 1);
                sifre = txtAdminSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNuma7_Click(object sender, EventArgs e)
        {
            sifre += "7";
            txtAdminSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtAdminSifre.Text = txtAdminSifre.Text.Substring(0, txtAdminSifre.Text.Length - 1);
                sifre = txtAdminSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNuma8_Click(object sender, EventArgs e)
        {
            sifre += "8";
            txtAdminSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtAdminSifre.Text = txtAdminSifre.Text.Substring(0, txtAdminSifre.Text.Length - 1);
                sifre = txtAdminSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNuma9_Click(object sender, EventArgs e)
        {
            sifre += "9";
            txtAdminSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtAdminSifre.Text = txtAdminSifre.Text.Substring(0, txtAdminSifre.Text.Length - 1);
                sifre = txtAdminSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNuma0_Click(object sender, EventArgs e)
        {
            sifre += "0";
            txtAdminSifre.Text = sifre;
            if (sifre.Length > 4)
            {
                txtAdminSifre.Text = txtAdminSifre.Text.Substring(0, txtAdminSifre.Text.Length - 1);
                sifre = txtAdminSifre.Text;
                MessageBox.Show("Şifre 4 Haneli Olmalıdır.");
            }
        }

        private void btnNumaGeriAl_Click(object sender, EventArgs e)
        {

            if (sifre != "")
            {
                txtAdminSifre.Text = txtAdminSifre.Text.Substring(0, txtAdminSifre.Text.Length - 1);
                sifre = txtAdminSifre.Text;
            }
        }
        private void btnNumaCikis_Click(object sender, EventArgs e)
        {
            DialogResult uyari = MessageBox.Show("Uygulamayı Kapatmak İstiyor musunuz?", "UYGULAMA ÇIKIŞ", MessageBoxButtons.YesNo);
            if (uyari == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNumaTemizle_Click(object sender, EventArgs e)
        {
            txtAdminSifre.Text = "";
            sifre = txtAdminSifre.Text;
        }
        private void btnNumaGiris_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM admin where ADMIN=@user AND PASS=@pass";
            SqlCommand giris = new SqlCommand(sorgu, baglanti);
            giris.Parameters.AddWithValue("@user", cmbAdmin.Text);
            giris.Parameters.AddWithValue("@pass", txtAdminSifre.Text);
            baglanti.Open();
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                personel.personelid = cmbAdmin.Text;
                baglanti.Close();
                SqlCommand hareket = new SqlCommand("INSERT INTO personelhareketleri (KULLANICI,ISLEMTURU,ISLEMTARIHI) VALUES(@kullanici,@islemturu,@islemtarihi)", baglanti);
                hareket.Parameters.AddWithValue("@kullanici", cmbAdmin.Text);
                hareket.Parameters.AddWithValue("@islemturu", "GİRİŞ");
                hareket.Parameters.AddWithValue("islemtarihi", DateTime.Now);
                baglanti.Open();
                hareket.ExecuteNonQuery();
                baglanti.Close();
                frmAnaMenu frm = new frmAnaMenu();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Eşleşmiyor.");
                baglanti.Close();

            }
        }

        private void rdbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnAdmin.Visible = false;
            txtSifre.Text = "";
            sifre = txtSifre.Text;
            lblAdminGirisi.Visible = true;
            pnlAdmin.Location = new Point(397, 123);
            pnlAdmin.Height = 469;
            pnlAdmin.Width = 202;
            pnlAdmin.Visible = true;

            baglanti.Open();
            SqlCommand admin = new SqlCommand("select (ADMIN) from admin", baglanti);
            SqlDataReader areader;
            areader = admin.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ADMIN", typeof(string));
            dt.Load(areader);
            cmbAdmin.ValueMember = "ADMIN";
            cmbAdmin.DataSource = dt;
            baglanti.Close();
            rdbtnPersonel.Checked = false;
        }

        private void rdbtnPersonel_CheckedChanged(object sender, EventArgs e)
        {
            lblAdminGirisi.Visible = false;
            pnlAdmin.Visible = false;
            txtAdminSifre.Text = "";
            sifre = txtAdminSifre.Text;
            rdbtnAdmin.Visible = true;
            rdbtnAdmin.Checked = false;
        }


    }
}
