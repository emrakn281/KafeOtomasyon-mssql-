
namespace ProjeFinal
{
    partial class frmAyarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyarlar));
            this.lblGun = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.pnlTemaDegistir = new System.Windows.Forms.Panel();
            this.btnTema5 = new System.Windows.Forms.Button();
            this.btnTema3 = new System.Windows.Forms.Button();
            this.btnTema4 = new System.Windows.Forms.Button();
            this.btnTema2 = new System.Windows.Forms.Button();
            this.btnTema1 = new System.Windows.Forms.Button();
            this.lblTemaDegistir = new System.Windows.Forms.Label();
            this.pnlSifreDegistir = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKullanici = new System.Windows.Forms.ComboBox();
            this.btnVisibility3 = new System.Windows.Forms.Button();
            this.btnVisibility2 = new System.Windows.Forms.Button();
            this.btnVisibility1 = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblYeniSifreTekrar = new System.Windows.Forms.Label();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.lblMevcutSifre = new System.Windows.Forms.Label();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtYeniSifreGir = new System.Windows.Forms.TextBox();
            this.lblSifreDegistir = new System.Windows.Forms.Label();
            this.txtMevcutSifre = new System.Windows.Forms.TextBox();
            this.lblKullanan = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.pnlKafeBilgisi = new System.Windows.Forms.Panel();
            this.txtKafeAdi = new System.Windows.Forms.TextBox();
            this.lblKafeAdi = new System.Windows.Forms.Label();
            this.btnBilgiGüncelle = new System.Windows.Forms.Button();
            this.btnBilgiIptal = new System.Windows.Forms.Button();
            this.lblKafeAdres = new System.Windows.Forms.Label();
            this.lblKafeTel = new System.Windows.Forms.Label();
            this.txtKafeAdres = new System.Windows.Forms.TextBox();
            this.lblKafeBilgisi = new System.Windows.Forms.Label();
            this.txtKafeTel = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cntmnsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolAsagi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKafeBilgi = new System.Windows.Forms.Button();
            this.btnTemaDegistir = new System.Windows.Forms.Button();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnKilit = new System.Windows.Forms.Button();
            this.btnYemekMenu = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pnlTemaDegistir.SuspendLayout();
            this.pnlSifreDegistir.SuspendLayout();
            this.pnlKafeBilgisi.SuspendLayout();
            this.cntmnsRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.BackColor = System.Drawing.Color.Transparent;
            this.lblGun.ForeColor = System.Drawing.Color.Yellow;
            this.lblGun.Location = new System.Drawing.Point(930, 695);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(13, 13);
            this.lblGun.TabIndex = 69;
            this.lblGun.Text = "a";
            this.lblGun.Visible = false;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTarih.ForeColor = System.Drawing.Color.Yellow;
            this.lblTarih.Location = new System.Drawing.Point(831, 707);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(29, 31);
            this.lblTarih.TabIndex = 67;
            this.lblTarih.Text = "a";
            this.lblTarih.MouseLeave += new System.EventHandler(this.lblTarih_MouseLeave);
            this.lblTarih.MouseHover += new System.EventHandler(this.lblTarih_MouseHover);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSaat.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaat.Location = new System.Drawing.Point(844, 663);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(29, 31);
            this.lblSaat.TabIndex = 68;
            this.lblSaat.Text = "b";
            // 
            // pnlTemaDegistir
            // 
            this.pnlTemaDegistir.BackColor = System.Drawing.Color.Transparent;
            this.pnlTemaDegistir.Controls.Add(this.btnTema5);
            this.pnlTemaDegistir.Controls.Add(this.btnTema3);
            this.pnlTemaDegistir.Controls.Add(this.btnTema4);
            this.pnlTemaDegistir.Controls.Add(this.btnTema2);
            this.pnlTemaDegistir.Controls.Add(this.btnTema1);
            this.pnlTemaDegistir.Controls.Add(this.lblTemaDegistir);
            this.pnlTemaDegistir.Location = new System.Drawing.Point(333, 34);
            this.pnlTemaDegistir.Name = "pnlTemaDegistir";
            this.pnlTemaDegistir.Size = new System.Drawing.Size(37, 566);
            this.pnlTemaDegistir.TabIndex = 74;
            this.pnlTemaDegistir.Visible = false;
            // 
            // btnTema5
            // 
            this.btnTema5.BackgroundImage = global::ProjeFinal.Properties.Resources.Background5;
            this.btnTema5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTema5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTema5.Location = new System.Drawing.Point(353, 328);
            this.btnTema5.Name = "btnTema5";
            this.btnTema5.Size = new System.Drawing.Size(200, 200);
            this.btnTema5.TabIndex = 1;
            this.btnTema5.UseVisualStyleBackColor = true;
            this.btnTema5.Click += new System.EventHandler(this.btnTema5_Click);
            // 
            // btnTema3
            // 
            this.btnTema3.BackgroundImage = global::ProjeFinal.Properties.Resources.Background3;
            this.btnTema3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTema3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTema3.Location = new System.Drawing.Point(415, 122);
            this.btnTema3.Name = "btnTema3";
            this.btnTema3.Size = new System.Drawing.Size(200, 200);
            this.btnTema3.TabIndex = 1;
            this.btnTema3.UseVisualStyleBackColor = true;
            this.btnTema3.Click += new System.EventHandler(this.btnTema3_Click);
            // 
            // btnTema4
            // 
            this.btnTema4.BackgroundImage = global::ProjeFinal.Properties.Resources.Background4;
            this.btnTema4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTema4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTema4.Location = new System.Drawing.Point(147, 328);
            this.btnTema4.Name = "btnTema4";
            this.btnTema4.Size = new System.Drawing.Size(200, 200);
            this.btnTema4.TabIndex = 1;
            this.btnTema4.UseVisualStyleBackColor = true;
            this.btnTema4.Click += new System.EventHandler(this.btnTema4_Click);
            // 
            // btnTema2
            // 
            this.btnTema2.BackgroundImage = global::ProjeFinal.Properties.Resources.Background2;
            this.btnTema2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTema2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTema2.Location = new System.Drawing.Point(209, 122);
            this.btnTema2.Name = "btnTema2";
            this.btnTema2.Size = new System.Drawing.Size(200, 200);
            this.btnTema2.TabIndex = 1;
            this.btnTema2.UseVisualStyleBackColor = true;
            this.btnTema2.Click += new System.EventHandler(this.btnTema2_Click);
            // 
            // btnTema1
            // 
            this.btnTema1.BackgroundImage = global::ProjeFinal.Properties.Resources.Background1;
            this.btnTema1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTema1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTema1.Location = new System.Drawing.Point(3, 122);
            this.btnTema1.Name = "btnTema1";
            this.btnTema1.Size = new System.Drawing.Size(200, 200);
            this.btnTema1.TabIndex = 1;
            this.btnTema1.UseVisualStyleBackColor = true;
            this.btnTema1.Click += new System.EventHandler(this.btnTema1_Click);
            // 
            // lblTemaDegistir
            // 
            this.lblTemaDegistir.AutoSize = true;
            this.lblTemaDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTemaDegistir.Location = new System.Drawing.Point(85, 11);
            this.lblTemaDegistir.Name = "lblTemaDegistir";
            this.lblTemaDegistir.Size = new System.Drawing.Size(446, 63);
            this.lblTemaDegistir.TabIndex = 0;
            this.lblTemaDegistir.Text = "TEMA DEĞİŞTİR";
            // 
            // pnlSifreDegistir
            // 
            this.pnlSifreDegistir.BackColor = System.Drawing.Color.Transparent;
            this.pnlSifreDegistir.Controls.Add(this.label1);
            this.pnlSifreDegistir.Controls.Add(this.cmbKullanici);
            this.pnlSifreDegistir.Controls.Add(this.btnVisibility3);
            this.pnlSifreDegistir.Controls.Add(this.btnVisibility2);
            this.pnlSifreDegistir.Controls.Add(this.btnVisibility1);
            this.pnlSifreDegistir.Controls.Add(this.btnOnayla);
            this.pnlSifreDegistir.Controls.Add(this.btnIptal);
            this.pnlSifreDegistir.Controls.Add(this.lblYeniSifreTekrar);
            this.pnlSifreDegistir.Controls.Add(this.lblYeniSifre);
            this.pnlSifreDegistir.Controls.Add(this.lblMevcutSifre);
            this.pnlSifreDegistir.Controls.Add(this.txtYeniSifreTekrar);
            this.pnlSifreDegistir.Controls.Add(this.txtYeniSifreGir);
            this.pnlSifreDegistir.Controls.Add(this.lblSifreDegistir);
            this.pnlSifreDegistir.Controls.Add(this.txtMevcutSifre);
            this.pnlSifreDegistir.Location = new System.Drawing.Point(511, 34);
            this.pnlSifreDegistir.Name = "pnlSifreDegistir";
            this.pnlSifreDegistir.Size = new System.Drawing.Size(402, 598);
            this.pnlSifreDegistir.TabIndex = 73;
            this.pnlSifreDegistir.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adını Seçiniz";
            // 
            // cmbKullanici
            // 
            this.cmbKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKullanici.FormattingEnabled = true;
            this.cmbKullanici.Location = new System.Drawing.Point(287, 138);
            this.cmbKullanici.Name = "cmbKullanici";
            this.cmbKullanici.Size = new System.Drawing.Size(253, 69);
            this.cmbKullanici.TabIndex = 5;
            // 
            // btnVisibility3
            // 
            this.btnVisibility3.BackColor = System.Drawing.SystemColors.Window;
            this.btnVisibility3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisibility3.BackgroundImage")));
            this.btnVisibility3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVisibility3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVisibility3.Location = new System.Drawing.Point(500, 379);
            this.btnVisibility3.Name = "btnVisibility3";
            this.btnVisibility3.Size = new System.Drawing.Size(30, 30);
            this.btnVisibility3.TabIndex = 4;
            this.btnVisibility3.UseVisualStyleBackColor = false;
            this.btnVisibility3.MouseLeave += new System.EventHandler(this.btnVisibility3_MouseLeave);
            this.btnVisibility3.MouseHover += new System.EventHandler(this.btnVisibility3_MouseHover);
            // 
            // btnVisibility2
            // 
            this.btnVisibility2.BackColor = System.Drawing.SystemColors.Window;
            this.btnVisibility2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisibility2.BackgroundImage")));
            this.btnVisibility2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVisibility2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVisibility2.Location = new System.Drawing.Point(500, 304);
            this.btnVisibility2.Name = "btnVisibility2";
            this.btnVisibility2.Size = new System.Drawing.Size(30, 30);
            this.btnVisibility2.TabIndex = 4;
            this.btnVisibility2.UseVisualStyleBackColor = false;
            this.btnVisibility2.MouseLeave += new System.EventHandler(this.btnVisibility2_MouseLeave);
            this.btnVisibility2.MouseHover += new System.EventHandler(this.btnVisibility2_MouseHover);
            // 
            // btnVisibility1
            // 
            this.btnVisibility1.BackColor = System.Drawing.SystemColors.Window;
            this.btnVisibility1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisibility1.BackgroundImage")));
            this.btnVisibility1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVisibility1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVisibility1.Location = new System.Drawing.Point(500, 229);
            this.btnVisibility1.Name = "btnVisibility1";
            this.btnVisibility1.Size = new System.Drawing.Size(30, 30);
            this.btnVisibility1.TabIndex = 4;
            this.btnVisibility1.UseVisualStyleBackColor = false;
            this.btnVisibility1.MouseLeave += new System.EventHandler(this.btnVisibility1_MouseLeave);
            this.btnVisibility1.MouseHover += new System.EventHandler(this.btnVisibility1_MouseHover);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.Lime;
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(375, 465);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(100, 100);
            this.btnOnayla.TabIndex = 3;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(150, 465);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 100);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İPTAL ET";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblYeniSifreTekrar
            // 
            this.lblYeniSifreTekrar.AutoSize = true;
            this.lblYeniSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniSifreTekrar.Location = new System.Drawing.Point(62, 387);
            this.lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            this.lblYeniSifreTekrar.Size = new System.Drawing.Size(217, 31);
            this.lblYeniSifreTekrar.TabIndex = 2;
            this.lblYeniSifreTekrar.Text = "Yeni Şifre Tekrar";
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniSifre.Location = new System.Drawing.Point(64, 313);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(215, 31);
            this.lblYeniSifre.TabIndex = 2;
            this.lblYeniSifre.Text = "Yeni Şifre Giriniz";
            // 
            // lblMevcutSifre
            // 
            this.lblMevcutSifre.AutoSize = true;
            this.lblMevcutSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMevcutSifre.Location = new System.Drawing.Point(12, 239);
            this.lblMevcutSifre.Name = "lblMevcutSifre";
            this.lblMevcutSifre.Size = new System.Drawing.Size(269, 31);
            this.lblMevcutSifre.TabIndex = 2;
            this.lblMevcutSifre.Text = "Mevcut Şifreyi Giriniz";
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(287, 361);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.PasswordChar = '*';
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(253, 68);
            this.txtYeniSifreTekrar.TabIndex = 1;
            this.txtYeniSifreTekrar.TextChanged += new System.EventHandler(this.txtYeniSifreTekrar_TextChanged);
            this.txtYeniSifreTekrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYeniSifreTekrar_KeyPress);
            // 
            // txtYeniSifreGir
            // 
            this.txtYeniSifreGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifreGir.Location = new System.Drawing.Point(287, 287);
            this.txtYeniSifreGir.Name = "txtYeniSifreGir";
            this.txtYeniSifreGir.PasswordChar = '*';
            this.txtYeniSifreGir.Size = new System.Drawing.Size(253, 68);
            this.txtYeniSifreGir.TabIndex = 1;
            this.txtYeniSifreGir.TextChanged += new System.EventHandler(this.txtYeniSifreGir_TextChanged);
            this.txtYeniSifreGir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYeniSifreGir_KeyPress);
            // 
            // lblSifreDegistir
            // 
            this.lblSifreDegistir.AutoSize = true;
            this.lblSifreDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreDegistir.Location = new System.Drawing.Point(85, 11);
            this.lblSifreDegistir.Name = "lblSifreDegistir";
            this.lblSifreDegistir.Size = new System.Drawing.Size(455, 63);
            this.lblSifreDegistir.TabIndex = 0;
            this.lblSifreDegistir.Text = "ŞİFRE DEĞİŞTİR";
            this.lblSifreDegistir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMevcutSifre
            // 
            this.txtMevcutSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMevcutSifre.Location = new System.Drawing.Point(287, 213);
            this.txtMevcutSifre.Name = "txtMevcutSifre";
            this.txtMevcutSifre.PasswordChar = '*';
            this.txtMevcutSifre.Size = new System.Drawing.Size(253, 68);
            this.txtMevcutSifre.TabIndex = 1;
            this.txtMevcutSifre.TextChanged += new System.EventHandler(this.txtMevcutSifre_TextChanged);
            this.txtMevcutSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMevcutSifre_KeyPress);
            // 
            // lblKullanan
            // 
            this.lblKullanan.AutoSize = true;
            this.lblKullanan.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanan.ForeColor = System.Drawing.Color.White;
            this.lblKullanan.Location = new System.Drawing.Point(810, 9);
            this.lblKullanan.Name = "lblKullanan";
            this.lblKullanan.Size = new System.Drawing.Size(85, 20);
            this.lblKullanan.TabIndex = 76;
            this.lblKullanan.Text = "Kullanıcı :";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.White;
            this.lblKullanici.Location = new System.Drawing.Point(891, 9);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(87, 20);
            this.lblKullanici.TabIndex = 75;
            this.lblKullanici.Text = "kullanıcıid\r\n";
            // 
            // pnlKafeBilgisi
            // 
            this.pnlKafeBilgisi.BackColor = System.Drawing.Color.Transparent;
            this.pnlKafeBilgisi.Controls.Add(this.txtKafeAdi);
            this.pnlKafeBilgisi.Controls.Add(this.lblKafeAdi);
            this.pnlKafeBilgisi.Controls.Add(this.btnBilgiGüncelle);
            this.pnlKafeBilgisi.Controls.Add(this.btnBilgiIptal);
            this.pnlKafeBilgisi.Controls.Add(this.lblKafeAdres);
            this.pnlKafeBilgisi.Controls.Add(this.lblKafeTel);
            this.pnlKafeBilgisi.Controls.Add(this.txtKafeAdres);
            this.pnlKafeBilgisi.Controls.Add(this.lblKafeBilgisi);
            this.pnlKafeBilgisi.Controls.Add(this.txtKafeTel);
            this.pnlKafeBilgisi.Location = new System.Drawing.Point(264, 34);
            this.pnlKafeBilgisi.Name = "pnlKafeBilgisi";
            this.pnlKafeBilgisi.Size = new System.Drawing.Size(48, 598);
            this.pnlKafeBilgisi.TabIndex = 74;
            this.pnlKafeBilgisi.Visible = false;
            // 
            // txtKafeAdi
            // 
            this.txtKafeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKafeAdi.Location = new System.Drawing.Point(287, 139);
            this.txtKafeAdi.Multiline = true;
            this.txtKafeAdi.Name = "txtKafeAdi";
            this.txtKafeAdi.Size = new System.Drawing.Size(253, 68);
            this.txtKafeAdi.TabIndex = 7;
            // 
            // lblKafeAdi
            // 
            this.lblKafeAdi.AutoSize = true;
            this.lblKafeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKafeAdi.Location = new System.Drawing.Point(79, 164);
            this.lblKafeAdi.Name = "lblKafeAdi";
            this.lblKafeAdi.Size = new System.Drawing.Size(200, 31);
            this.lblKafeAdi.TabIndex = 6;
            this.lblKafeAdi.Text = "Kafe Adı Giriniz";
            // 
            // btnBilgiGüncelle
            // 
            this.btnBilgiGüncelle.BackColor = System.Drawing.Color.Lime;
            this.btnBilgiGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBilgiGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiGüncelle.Location = new System.Drawing.Point(375, 465);
            this.btnBilgiGüncelle.Name = "btnBilgiGüncelle";
            this.btnBilgiGüncelle.Size = new System.Drawing.Size(100, 100);
            this.btnBilgiGüncelle.TabIndex = 3;
            this.btnBilgiGüncelle.Text = "ONAYLA";
            this.btnBilgiGüncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGüncelle.Click += new System.EventHandler(this.btnBilgiGüncelle_Click);
            // 
            // btnBilgiIptal
            // 
            this.btnBilgiIptal.BackColor = System.Drawing.Color.Red;
            this.btnBilgiIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBilgiIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiIptal.Location = new System.Drawing.Point(150, 465);
            this.btnBilgiIptal.Name = "btnBilgiIptal";
            this.btnBilgiIptal.Size = new System.Drawing.Size(100, 100);
            this.btnBilgiIptal.TabIndex = 3;
            this.btnBilgiIptal.Text = "İPTAL ET";
            this.btnBilgiIptal.UseVisualStyleBackColor = false;
            this.btnBilgiIptal.Click += new System.EventHandler(this.btnBilgiIptal_Click);
            // 
            // lblKafeAdres
            // 
            this.lblKafeAdres.AutoSize = true;
            this.lblKafeAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKafeAdres.Location = new System.Drawing.Point(41, 313);
            this.lblKafeAdres.Name = "lblKafeAdres";
            this.lblKafeAdres.Size = new System.Drawing.Size(238, 31);
            this.lblKafeAdres.TabIndex = 2;
            this.lblKafeAdres.Text = "Kafe Adresi Giriniz";
            // 
            // lblKafeTel
            // 
            this.lblKafeTel.AutoSize = true;
            this.lblKafeTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKafeTel.Location = new System.Drawing.Point(51, 239);
            this.lblKafeTel.Name = "lblKafeTel";
            this.lblKafeTel.Size = new System.Drawing.Size(228, 31);
            this.lblKafeTel.TabIndex = 2;
            this.lblKafeTel.Text = "Telefon Numarası";
            // 
            // txtKafeAdres
            // 
            this.txtKafeAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKafeAdres.Location = new System.Drawing.Point(287, 287);
            this.txtKafeAdres.Multiline = true;
            this.txtKafeAdres.Name = "txtKafeAdres";
            this.txtKafeAdres.Size = new System.Drawing.Size(253, 68);
            this.txtKafeAdres.TabIndex = 1;
            // 
            // lblKafeBilgisi
            // 
            this.lblKafeBilgisi.AutoSize = true;
            this.lblKafeBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKafeBilgisi.Location = new System.Drawing.Point(85, 11);
            this.lblKafeBilgisi.Name = "lblKafeBilgisi";
            this.lblKafeBilgisi.Size = new System.Drawing.Size(371, 63);
            this.lblKafeBilgisi.TabIndex = 0;
            this.lblKafeBilgisi.Text = "KAFE BİLGİSİ";
            this.lblKafeBilgisi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtKafeTel
            // 
            this.txtKafeTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKafeTel.Location = new System.Drawing.Point(287, 213);
            this.txtKafeTel.Multiline = true;
            this.txtKafeTel.Name = "txtKafeTel";
            this.txtKafeTel.Size = new System.Drawing.Size(253, 68);
            this.txtKafeTel.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cntmnsRightClick
            // 
            this.cntmnsRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAsagi,
            this.toolKapat,
            this.toolRestart});
            this.cntmnsRightClick.Name = "cntmnsRightClick";
            this.cntmnsRightClick.Size = new System.Drawing.Size(217, 70);
            // 
            // toolAsagi
            // 
            this.toolAsagi.Name = "toolAsagi";
            this.toolAsagi.Size = new System.Drawing.Size(216, 22);
            this.toolAsagi.Text = "Uygulamayı Aşağı Al";
            this.toolAsagi.Click += new System.EventHandler(this.toolAsagi_Click);
            // 
            // toolKapat
            // 
            this.toolKapat.Name = "toolKapat";
            this.toolKapat.Size = new System.Drawing.Size(216, 22);
            this.toolKapat.Text = "Uygulamayı Kapat";
            this.toolKapat.Click += new System.EventHandler(this.toolKapat_Click);
            // 
            // toolRestart
            // 
            this.toolRestart.Name = "toolRestart";
            this.toolRestart.Size = new System.Drawing.Size(216, 22);
            this.toolRestart.Text = "Uygulamayı Yeniden Başlat";
            this.toolRestart.Click += new System.EventHandler(this.toolRestart_Click);
            // 
            // btnKafeBilgi
            // 
            this.btnKafeBilgi.BackColor = System.Drawing.Color.Transparent;
            this.btnKafeBilgi.BackgroundImage = global::ProjeFinal.Properties.Resources.info;
            this.btnKafeBilgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKafeBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKafeBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKafeBilgi.Location = new System.Drawing.Point(12, 279);
            this.btnKafeBilgi.Name = "btnKafeBilgi";
            this.btnKafeBilgi.Size = new System.Drawing.Size(150, 110);
            this.btnKafeBilgi.TabIndex = 77;
            this.btnKafeBilgi.UseVisualStyleBackColor = false;
            this.btnKafeBilgi.Click += new System.EventHandler(this.btnKafeBilgi_Click);
            // 
            // btnTemaDegistir
            // 
            this.btnTemaDegistir.BackColor = System.Drawing.Color.Transparent;
            this.btnTemaDegistir.BackgroundImage = global::ProjeFinal.Properties.Resources.theme_icon;
            this.btnTemaDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTemaDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemaDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemaDegistir.Location = new System.Drawing.Point(12, 145);
            this.btnTemaDegistir.Name = "btnTemaDegistir";
            this.btnTemaDegistir.Size = new System.Drawing.Size(150, 110);
            this.btnTemaDegistir.TabIndex = 71;
            this.btnTemaDegistir.UseVisualStyleBackColor = false;
            this.btnTemaDegistir.Click += new System.EventHandler(this.btnTemaDegistir_Click);
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.BackColor = System.Drawing.Color.Transparent;
            this.btnSifreDegistir.BackgroundImage = global::ProjeFinal.Properties.Resources.Password_icon;
            this.btnSifreDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSifreDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSifreDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreDegistir.Location = new System.Drawing.Point(12, 12);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(150, 110);
            this.btnSifreDegistir.TabIndex = 72;
            this.btnSifreDegistir.UseVisualStyleBackColor = false;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPersoneller.BackgroundImage = global::ProjeFinal.Properties.Resources.personeller1;
            this.btnPersoneller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPersoneller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersoneller.Location = new System.Drawing.Point(562, 663);
            this.btnPersoneller.Margin = new System.Windows.Forms.Padding(0);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(125, 75);
            this.btnPersoneller.TabIndex = 70;
            this.btnPersoneller.UseVisualStyleBackColor = false;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnKilit
            // 
            this.btnKilit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(193)))), ((int)(((byte)(30)))));
            this.btnKilit.BackgroundImage = global::ProjeFinal.Properties.Resources.Lock_icon;
            this.btnKilit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKilit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKilit.Location = new System.Drawing.Point(687, 663);
            this.btnKilit.Margin = new System.Windows.Forms.Padding(0);
            this.btnKilit.Name = "btnKilit";
            this.btnKilit.Size = new System.Drawing.Size(125, 75);
            this.btnKilit.TabIndex = 62;
            this.btnKilit.UseVisualStyleBackColor = false;
            this.btnKilit.Click += new System.EventHandler(this.btnKilit_Click);
            // 
            // btnYemekMenu
            // 
            this.btnYemekMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnYemekMenu.BackgroundImage = global::ProjeFinal.Properties.Resources.restaurant_menu;
            this.btnYemekMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYemekMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYemekMenu.Location = new System.Drawing.Point(312, 663);
            this.btnYemekMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnYemekMenu.Name = "btnYemekMenu";
            this.btnYemekMenu.Size = new System.Drawing.Size(125, 75);
            this.btnYemekMenu.TabIndex = 63;
            this.btnYemekMenu.UseVisualStyleBackColor = false;
            this.btnYemekMenu.Click += new System.EventHandler(this.btnYemekMenu_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.DarkGray;
            this.btnAyarlar.BackgroundImage = global::ProjeFinal.Properties.Resources.settings_icon;
            this.btnAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyarlar.Location = new System.Drawing.Point(437, 663);
            this.btnAyarlar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(125, 75);
            this.btnAyarlar.TabIndex = 64;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSiparis.BackgroundImage = global::ProjeFinal.Properties.Resources.fork_and_knife_with_plate_icon;
            this.btnSiparis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparis.Location = new System.Drawing.Point(187, 663);
            this.btnSiparis.Margin = new System.Windows.Forms.Padding(0);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(125, 75);
            this.btnSiparis.TabIndex = 66;
            this.btnSiparis.UseVisualStyleBackColor = false;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriDon.BackgroundImage = global::ProjeFinal.Properties.Resources.Undo;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriDon.Location = new System.Drawing.Point(87, 663);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(0);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 75);
            this.btnGeriDon.TabIndex = 60;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::ProjeFinal.Properties.Resources.delete_icon;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(12, 663);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 75);
            this.btnCikis.TabIndex = 61;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.ContextMenuStrip = this.cntmnsRightClick;
            this.Controls.Add(this.lblKullanan);
            this.Controls.Add(this.pnlKafeBilgisi);
            this.Controls.Add(this.btnKafeBilgi);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.pnlTemaDegistir);
            this.Controls.Add(this.pnlSifreDegistir);
            this.Controls.Add(this.btnTemaDegistir);
            this.Controls.Add(this.btnSifreDegistir);
            this.Controls.Add(this.btnPersoneller);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.btnKilit);
            this.Controls.Add(this.btnYemekMenu);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAyarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAyarlar";
            this.Load += new System.EventHandler(this.frmAyarlar_Load);
            this.pnlTemaDegistir.ResumeLayout(false);
            this.pnlTemaDegistir.PerformLayout();
            this.pnlSifreDegistir.ResumeLayout(false);
            this.pnlSifreDegistir.PerformLayout();
            this.pnlKafeBilgisi.ResumeLayout(false);
            this.pnlKafeBilgisi.PerformLayout();
            this.cntmnsRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Button btnKilit;
        private System.Windows.Forms.Button btnYemekMenu;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel pnlTemaDegistir;
        private System.Windows.Forms.Button btnTema5;
        private System.Windows.Forms.Button btnTema3;
        private System.Windows.Forms.Button btnTema4;
        private System.Windows.Forms.Button btnTema2;
        private System.Windows.Forms.Button btnTema1;
        private System.Windows.Forms.Label lblTemaDegistir;
        private System.Windows.Forms.Panel pnlSifreDegistir;
        private System.Windows.Forms.Button btnVisibility3;
        private System.Windows.Forms.Button btnVisibility2;
        private System.Windows.Forms.Button btnVisibility1;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblYeniSifreTekrar;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.Label lblMevcutSifre;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.TextBox txtYeniSifreGir;
        private System.Windows.Forms.Label lblSifreDegistir;
        private System.Windows.Forms.TextBox txtMevcutSifre;
        private System.Windows.Forms.Button btnTemaDegistir;
        private System.Windows.Forms.Button btnSifreDegistir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKullanici;
        private System.Windows.Forms.Label lblKullanan;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnKafeBilgi;
        private System.Windows.Forms.Panel pnlKafeBilgisi;
        private System.Windows.Forms.Label lblKafeAdi;
        private System.Windows.Forms.Button btnBilgiGüncelle;
        private System.Windows.Forms.Button btnBilgiIptal;
        private System.Windows.Forms.Label lblKafeAdres;
        private System.Windows.Forms.Label lblKafeTel;
        private System.Windows.Forms.TextBox txtKafeAdres;
        private System.Windows.Forms.Label lblKafeBilgisi;
        private System.Windows.Forms.TextBox txtKafeTel;
        private System.Windows.Forms.TextBox txtKafeAdi;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip cntmnsRightClick;
        private System.Windows.Forms.ToolStripMenuItem toolAsagi;
        private System.Windows.Forms.ToolStripMenuItem toolKapat;
        private System.Windows.Forms.ToolStripMenuItem toolRestart;
    }
}