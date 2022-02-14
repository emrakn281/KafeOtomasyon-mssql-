
namespace ProjeFinal
{
    partial class frmYemekMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYemekMenu));
            this.lblGun = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.yemekId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yemekKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yemekAdı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yemekFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstYemekListe = new System.Windows.Forms.ListView();
            this.btnYemekSil = new System.Windows.Forms.Button();
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnYeniYemek = new System.Windows.Forms.Button();
            this.cmbYeniYemekKategori = new System.Windows.Forms.ComboBox();
            this.txtYeniYemekFiyat = new System.Windows.Forms.TextBox();
            this.txtYeniYemekAdi = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cntmnsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolAsagi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKullanan = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnYemekMenu = new System.Windows.Forms.Button();
            this.btnKilit = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnTumuListele = new System.Windows.Forms.Button();
            this.btnYemekListe = new System.Windows.Forms.Button();
            this.cmbSirala = new System.Windows.Forms.ComboBox();
            this.lblSiralamaSec = new System.Windows.Forms.Label();
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
            this.lblGun.TabIndex = 58;
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
            this.lblTarih.TabIndex = 56;
            this.lblTarih.Text = "a";
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
            this.lblSaat.TabIndex = 57;
            this.lblSaat.Text = "b";
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
            this.btnGeriDon.TabIndex = 49;
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
            this.btnCikis.TabIndex = 50;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // yemekId
            // 
            this.yemekId.Text = "ID";
            this.yemekId.Width = 33;
            // 
            // yemekKategori
            // 
            this.yemekKategori.Text = "Kategori";
            this.yemekKategori.Width = 148;
            // 
            // yemekAdı
            // 
            this.yemekAdı.Text = "Yemek Adı";
            this.yemekAdı.Width = 125;
            // 
            // yemekFiyat
            // 
            this.yemekFiyat.Text = "Fiyat";
            this.yemekFiyat.Width = 123;
            // 
            // lstYemekListe
            // 
            this.lstYemekListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstYemekListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.yemekId,
            this.yemekKategori,
            this.yemekAdı,
            this.yemekFiyat});
            this.lstYemekListe.FullRowSelect = true;
            this.lstYemekListe.GridLines = true;
            this.lstYemekListe.HideSelection = false;
            this.lstYemekListe.Location = new System.Drawing.Point(12, 12);
            this.lstYemekListe.Name = "lstYemekListe";
            this.lstYemekListe.Size = new System.Drawing.Size(550, 645);
            this.lstYemekListe.TabIndex = 48;
            this.lstYemekListe.UseCompatibleStateImageBehavior = false;
            this.lstYemekListe.View = System.Windows.Forms.View.Details;
            this.lstYemekListe.SelectedIndexChanged += new System.EventHandler(this.lstYemekListe_SelectedIndexChanged);
            // 
            // btnYemekSil
            // 
            this.btnYemekSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYemekSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYemekSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYemekSil.ForeColor = System.Drawing.Color.Black;
            this.btnYemekSil.Location = new System.Drawing.Point(651, 459);
            this.btnYemekSil.Margin = new System.Windows.Forms.Padding(0);
            this.btnYemekSil.Name = "btnYemekSil";
            this.btnYemekSil.Size = new System.Drawing.Size(95, 75);
            this.btnYemekSil.TabIndex = 68;
            this.btnYemekSil.Text = "SİL";
            this.btnYemekSil.UseVisualStyleBackColor = false;
            this.btnYemekSil.Click += new System.EventHandler(this.btnYemekSil_Click);
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIptalEt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIptalEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptalEt.ForeColor = System.Drawing.Color.Black;
            this.btnIptalEt.Location = new System.Drawing.Point(678, 537);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(239, 75);
            this.btnIptalEt.TabIndex = 67;
            this.btnIptalEt.Text = "İPTAL ET";
            this.btnIptalEt.UseVisualStyleBackColor = false;
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(710, 380);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(164, 31);
            this.lblFiyat.TabIndex = 64;
            this.lblFiyat.Text = "Fiyatı Giriniz";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.BackColor = System.Drawing.Color.Transparent;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(681, 304);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(210, 31);
            this.lblKategori.TabIndex = 65;
            this.lblKategori.Text = "Kategori Seçiniz";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(672, 229);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(228, 31);
            this.lblAd.TabIndex = 66;
            this.lblAd.Text = "Yemek Adı Giriniz";
            // 
            // btnYeniYemek
            // 
            this.btnYeniYemek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnYeniYemek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniYemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniYemek.ForeColor = System.Drawing.Color.Black;
            this.btnYeniYemek.Location = new System.Drawing.Point(841, 459);
            this.btnYeniYemek.Margin = new System.Windows.Forms.Padding(0);
            this.btnYeniYemek.Name = "btnYeniYemek";
            this.btnYeniYemek.Size = new System.Drawing.Size(95, 75);
            this.btnYeniYemek.TabIndex = 63;
            this.btnYeniYemek.Text = "EKLE";
            this.btnYeniYemek.UseVisualStyleBackColor = false;
            this.btnYeniYemek.Click += new System.EventHandler(this.btnYeniYemek_Click);
            // 
            // cmbYeniYemekKategori
            // 
            this.cmbYeniYemekKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbYeniYemekKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYeniYemekKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYeniYemekKategori.FormattingEnabled = true;
            this.cmbYeniYemekKategori.Items.AddRange(new object[] {
            "Kahvaltılıklar",
            "Ana Yemekler",
            "Tatlılar",
            "İçecekler"});
            this.cmbYeniYemekKategori.Location = new System.Drawing.Point(687, 338);
            this.cmbYeniYemekKategori.Name = "cmbYeniYemekKategori";
            this.cmbYeniYemekKategori.Size = new System.Drawing.Size(204, 39);
            this.cmbYeniYemekKategori.TabIndex = 62;
            // 
            // txtYeniYemekFiyat
            // 
            this.txtYeniYemekFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtYeniYemekFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniYemekFiyat.Location = new System.Drawing.Point(716, 414);
            this.txtYeniYemekFiyat.Name = "txtYeniYemekFiyat";
            this.txtYeniYemekFiyat.Size = new System.Drawing.Size(158, 38);
            this.txtYeniYemekFiyat.TabIndex = 60;
            this.txtYeniYemekFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYeniYemekFiyat_KeyPress);
            // 
            // txtYeniYemekAdi
            // 
            this.txtYeniYemekAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtYeniYemekAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniYemekAdi.Location = new System.Drawing.Point(678, 263);
            this.txtYeniYemekAdi.Name = "txtYeniYemekAdi";
            this.txtYeniYemekAdi.Size = new System.Drawing.Size(222, 38);
            this.txtYeniYemekAdi.TabIndex = 61;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(746, 459);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(95, 75);
            this.btnGuncelle.TabIndex = 69;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            // lblKullanan
            // 
            this.lblKullanan.AutoSize = true;
            this.lblKullanan.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanan.ForeColor = System.Drawing.Color.White;
            this.lblKullanan.Location = new System.Drawing.Point(810, 9);
            this.lblKullanan.Name = "lblKullanan";
            this.lblKullanan.Size = new System.Drawing.Size(85, 20);
            this.lblKullanan.TabIndex = 71;
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
            this.lblKullanici.TabIndex = 70;
            this.lblKullanici.Text = "kullanıcıid\r\n";
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
            this.btnSiparis.TabIndex = 55;
            this.btnSiparis.UseVisualStyleBackColor = false;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
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
            this.btnAyarlar.TabIndex = 53;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
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
            this.btnYemekMenu.TabIndex = 52;
            this.btnYemekMenu.UseVisualStyleBackColor = false;
            this.btnYemekMenu.Click += new System.EventHandler(this.btnYemekMenu_Click);
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
            this.btnKilit.TabIndex = 51;
            this.btnKilit.UseVisualStyleBackColor = false;
            this.btnKilit.Click += new System.EventHandler(this.btnKilit_Click);
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
            this.btnPersoneller.TabIndex = 59;
            this.btnPersoneller.UseVisualStyleBackColor = false;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnTumuListele
            // 
            this.btnTumuListele.BackColor = System.Drawing.Color.Transparent;
            this.btnTumuListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTumuListele.Location = new System.Drawing.Point(785, 141);
            this.btnTumuListele.Name = "btnTumuListele";
            this.btnTumuListele.Size = new System.Drawing.Size(147, 23);
            this.btnTumuListele.TabIndex = 75;
            this.btnTumuListele.Text = "Tümünü Listele";
            this.btnTumuListele.UseVisualStyleBackColor = false;
            this.btnTumuListele.Click += new System.EventHandler(this.btnTumuListele_Click);
            // 
            // btnYemekListe
            // 
            this.btnYemekListe.BackColor = System.Drawing.Color.Transparent;
            this.btnYemekListe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYemekListe.Location = new System.Drawing.Point(638, 141);
            this.btnYemekListe.Name = "btnYemekListe";
            this.btnYemekListe.Size = new System.Drawing.Size(147, 23);
            this.btnYemekListe.TabIndex = 74;
            this.btnYemekListe.Text = "Listele";
            this.btnYemekListe.UseVisualStyleBackColor = false;
            this.btnYemekListe.Click += new System.EventHandler(this.btnYemekListe_Click);
            // 
            // cmbSirala
            // 
            this.cmbSirala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSirala.FormattingEnabled = true;
            this.cmbSirala.Items.AddRange(new object[] {
            "Kahvaltılıklar",
            "Ana Yemekler",
            "Tatlılar",
            "İçecekler"});
            this.cmbSirala.Location = new System.Drawing.Point(638, 89);
            this.cmbSirala.Name = "cmbSirala";
            this.cmbSirala.Size = new System.Drawing.Size(294, 46);
            this.cmbSirala.TabIndex = 73;
            // 
            // lblSiralamaSec
            // 
            this.lblSiralamaSec.AutoSize = true;
            this.lblSiralamaSec.BackColor = System.Drawing.Color.Transparent;
            this.lblSiralamaSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiralamaSec.Location = new System.Drawing.Point(632, 55);
            this.lblSiralamaSec.Name = "lblSiralamaSec";
            this.lblSiralamaSec.Size = new System.Drawing.Size(299, 31);
            this.lblSiralamaSec.TabIndex = 72;
            this.lblSiralamaSec.Text = "Sıralama Türü Seçiniz";
            // 
            // frmYemekMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.ContextMenuStrip = this.cntmnsRightClick;
            this.Controls.Add(this.btnTumuListele);
            this.Controls.Add(this.btnYemekListe);
            this.Controls.Add(this.cmbSirala);
            this.Controls.Add(this.lblSiralamaSec);
            this.Controls.Add(this.lblKullanan);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnYemekSil);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnYeniYemek);
            this.Controls.Add(this.cmbYeniYemekKategori);
            this.Controls.Add(this.txtYeniYemekFiyat);
            this.Controls.Add(this.txtYeniYemekAdi);
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
            this.Controls.Add(this.lstYemekListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYemekMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYemekMenu";
            this.Load += new System.EventHandler(this.frmYemekMenu_Load);
            this.cntmnsRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ColumnHeader yemekId;
        private System.Windows.Forms.ColumnHeader yemekKategori;
        private System.Windows.Forms.ColumnHeader yemekAdı;
        private System.Windows.Forms.ColumnHeader yemekFiyat;
        private System.Windows.Forms.ListView lstYemekListe;
        private System.Windows.Forms.Button btnYemekSil;
        private System.Windows.Forms.Button btnIptalEt;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnYeniYemek;
        private System.Windows.Forms.ComboBox cmbYeniYemekKategori;
        private System.Windows.Forms.TextBox txtYeniYemekFiyat;
        private System.Windows.Forms.TextBox txtYeniYemekAdi;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ContextMenuStrip cntmnsRightClick;
        private System.Windows.Forms.ToolStripMenuItem toolAsagi;
        private System.Windows.Forms.ToolStripMenuItem toolKapat;
        private System.Windows.Forms.ToolStripMenuItem toolRestart;
        private System.Windows.Forms.Label lblKullanan;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnYemekMenu;
        private System.Windows.Forms.Button btnKilit;
        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Button btnTumuListele;
        private System.Windows.Forms.Button btnYemekListe;
        private System.Windows.Forms.ComboBox cmbSirala;
        private System.Windows.Forms.Label lblSiralamaSec;
    }
}