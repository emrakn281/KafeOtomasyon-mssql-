
namespace ProjeFinal
{
    partial class frmOdeme
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ÜrünAdı", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdeme));
            this.lblMasaNum = new System.Windows.Forms.Label();
            this.lblKullanan = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblMasa = new System.Windows.Forms.Label();
            this.lstSiparisler = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUrunAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUrunAdet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUrunFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTur = new System.Windows.Forms.Label();
            this.lblToplamOdeme = new System.Windows.Forms.Label();
            this.lblIndirimTutari = new System.Windows.Forms.Label();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtAraToplam = new System.Windows.Forms.TextBox();
            this.txtIndirim = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cntmnsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolAsagi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOdemeOnayla = new System.Windows.Forms.Button();
            this.btnOdemeIptal = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnKilit = new System.Windows.Forms.Button();
            this.btnYemekMenu = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.cntmnsRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMasaNum
            // 
            this.lblMasaNum.AutoSize = true;
            this.lblMasaNum.BackColor = System.Drawing.Color.Transparent;
            this.lblMasaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNum.ForeColor = System.Drawing.Color.White;
            this.lblMasaNum.Location = new System.Drawing.Point(215, 19);
            this.lblMasaNum.Name = "lblMasaNum";
            this.lblMasaNum.Size = new System.Drawing.Size(65, 46);
            this.lblMasaNum.TabIndex = 145;
            this.lblMasaNum.Text = "no";
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
            this.lblKullanan.TabIndex = 139;
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
            this.lblKullanici.TabIndex = 138;
            this.lblKullanici.Text = "kullanıcıid\r\n";
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.BackColor = System.Drawing.Color.Transparent;
            this.lblGun.ForeColor = System.Drawing.Color.Yellow;
            this.lblGun.Location = new System.Drawing.Point(930, 695);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(13, 13);
            this.lblGun.TabIndex = 136;
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
            this.lblTarih.TabIndex = 134;
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
            this.lblSaat.TabIndex = 135;
            this.lblSaat.Text = "b";
            // 
            // lblMasa
            // 
            this.lblMasa.AutoSize = true;
            this.lblMasa.BackColor = System.Drawing.Color.Transparent;
            this.lblMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasa.ForeColor = System.Drawing.Color.White;
            this.lblMasa.Location = new System.Drawing.Point(90, 19);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(134, 46);
            this.lblMasa.TabIndex = 109;
            this.lblMasa.Text = "MASA";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstSiparisler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSiparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.clmUrunAd,
            this.clmUrunAdet,
            this.clmUrunFiyat});
            this.lstSiparisler.FullRowSelect = true;
            this.lstSiparisler.GridLines = true;
            listViewGroup1.Header = "ÜrünAdı";
            listViewGroup1.Name = "grpUrunAd";
            this.lstSiparisler.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lstSiparisler.HideSelection = false;
            this.lstSiparisler.Location = new System.Drawing.Point(12, 90);
            this.lstSiparisler.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(383, 516);
            this.lstSiparisler.TabIndex = 108;
            this.lstSiparisler.UseCompatibleStateImageBehavior = false;
            this.lstSiparisler.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 1;
            // 
            // clmUrunAd
            // 
            this.clmUrunAd.Text = "Ürün Adı";
            this.clmUrunAd.Width = 203;
            // 
            // clmUrunAdet
            // 
            this.clmUrunAdet.Text = "Adet";
            this.clmUrunAdet.Width = 72;
            // 
            // clmUrunFiyat
            // 
            this.clmUrunFiyat.Text = "Fiyat";
            this.clmUrunFiyat.Width = 102;
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.BackColor = System.Drawing.Color.Transparent;
            this.lblTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTur.ForeColor = System.Drawing.Color.White;
            this.lblTur.Location = new System.Drawing.Point(429, 381);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(175, 31);
            this.lblTur.TabIndex = 156;
            this.lblTur.Text = "Ödeme Türü";
            this.lblTur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblToplamOdeme
            // 
            this.lblToplamOdeme.AutoSize = true;
            this.lblToplamOdeme.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamOdeme.ForeColor = System.Drawing.Color.White;
            this.lblToplamOdeme.Location = new System.Drawing.Point(410, 322);
            this.lblToplamOdeme.Name = "lblToplamOdeme";
            this.lblToplamOdeme.Size = new System.Drawing.Size(194, 31);
            this.lblToplamOdeme.TabIndex = 155;
            this.lblToplamOdeme.Text = "Toplam Tutarı";
            this.lblToplamOdeme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIndirimTutari
            // 
            this.lblIndirimTutari.AutoSize = true;
            this.lblIndirimTutari.BackColor = System.Drawing.Color.Transparent;
            this.lblIndirimTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIndirimTutari.ForeColor = System.Drawing.Color.White;
            this.lblIndirimTutari.Location = new System.Drawing.Point(418, 263);
            this.lblIndirimTutari.Name = "lblIndirimTutari";
            this.lblIndirimTutari.Size = new System.Drawing.Size(186, 31);
            this.lblIndirimTutari.TabIndex = 154;
            this.lblIndirimTutari.Text = "İndirim Tutarı";
            this.lblIndirimTutari.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.AutoSize = true;
            this.lblAraToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblAraToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraToplam.ForeColor = System.Drawing.Color.White;
            this.lblAraToplam.Location = new System.Drawing.Point(441, 204);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Size = new System.Drawing.Size(163, 31);
            this.lblAraToplam.TabIndex = 153;
            this.lblAraToplam.Text = "Ara Toplam";
            this.lblAraToplam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 46);
            this.label1.TabIndex = 152;
            this.label1.Text = "ÖDEME EKRANI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Banka Kartı"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(610, 373);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(250, 46);
            this.cmbOdemeTuru.TabIndex = 149;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Location = new System.Drawing.Point(610, 314);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(250, 45);
            this.txtToplamTutar.TabIndex = 148;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraToplam.Location = new System.Drawing.Point(610, 196);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.ReadOnly = true;
            this.txtAraToplam.Size = new System.Drawing.Size(250, 45);
            this.txtAraToplam.TabIndex = 147;
            // 
            // txtIndirim
            // 
            this.txtIndirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIndirim.Location = new System.Drawing.Point(610, 255);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(250, 45);
            this.txtIndirim.TabIndex = 146;
            this.txtIndirim.Click += new System.EventHandler(this.txtIndirim_Click);
            this.txtIndirim.TextChanged += new System.EventHandler(this.txtIndirim_TextChanged);
            this.txtIndirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIndirim_KeyPress);
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
            // btnOdemeOnayla
            // 
            this.btnOdemeOnayla.BackColor = System.Drawing.Color.Lime;
            this.btnOdemeOnayla.BackgroundImage = global::ProjeFinal.Properties.Resources.Dollar_icon;
            this.btnOdemeOnayla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOdemeOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdemeOnayla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOdemeOnayla.Location = new System.Drawing.Point(513, 462);
            this.btnOdemeOnayla.Margin = new System.Windows.Forms.Padding(0);
            this.btnOdemeOnayla.Name = "btnOdemeOnayla";
            this.btnOdemeOnayla.Size = new System.Drawing.Size(125, 75);
            this.btnOdemeOnayla.TabIndex = 151;
            this.btnOdemeOnayla.UseVisualStyleBackColor = false;
            this.btnOdemeOnayla.Click += new System.EventHandler(this.btnOdemeOnayla_Click);
            // 
            // btnOdemeIptal
            // 
            this.btnOdemeIptal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOdemeIptal.BackgroundImage = global::ProjeFinal.Properties.Resources.delete_icon;
            this.btnOdemeIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOdemeIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdemeIptal.Location = new System.Drawing.Point(638, 462);
            this.btnOdemeIptal.Margin = new System.Windows.Forms.Padding(0);
            this.btnOdemeIptal.Name = "btnOdemeIptal";
            this.btnOdemeIptal.Size = new System.Drawing.Size(125, 75);
            this.btnOdemeIptal.TabIndex = 150;
            this.btnOdemeIptal.UseVisualStyleBackColor = false;
            this.btnOdemeIptal.Click += new System.EventHandler(this.btnOdemeIptal_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPersoneller.BackgroundImage = global::ProjeFinal.Properties.Resources.personeller1;
            this.btnPersoneller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPersoneller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersoneller.Location = new System.Drawing.Point(562, 664);
            this.btnPersoneller.Margin = new System.Windows.Forms.Padding(0);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(125, 75);
            this.btnPersoneller.TabIndex = 137;
            this.btnPersoneller.UseVisualStyleBackColor = false;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnKilit
            // 
            this.btnKilit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(193)))), ((int)(((byte)(30)))));
            this.btnKilit.BackgroundImage = global::ProjeFinal.Properties.Resources.Lock_icon;
            this.btnKilit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKilit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKilit.Location = new System.Drawing.Point(687, 664);
            this.btnKilit.Margin = new System.Windows.Forms.Padding(0);
            this.btnKilit.Name = "btnKilit";
            this.btnKilit.Size = new System.Drawing.Size(125, 75);
            this.btnKilit.TabIndex = 129;
            this.btnKilit.UseVisualStyleBackColor = false;
            this.btnKilit.Click += new System.EventHandler(this.btnKilit_Click);
            // 
            // btnYemekMenu
            // 
            this.btnYemekMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnYemekMenu.BackgroundImage = global::ProjeFinal.Properties.Resources.restaurant_menu;
            this.btnYemekMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYemekMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYemekMenu.Location = new System.Drawing.Point(312, 664);
            this.btnYemekMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnYemekMenu.Name = "btnYemekMenu";
            this.btnYemekMenu.Size = new System.Drawing.Size(125, 75);
            this.btnYemekMenu.TabIndex = 130;
            this.btnYemekMenu.UseVisualStyleBackColor = false;
            this.btnYemekMenu.Click += new System.EventHandler(this.btnYemekMenu_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.DarkGray;
            this.btnAyarlar.BackgroundImage = global::ProjeFinal.Properties.Resources.settings_icon;
            this.btnAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyarlar.Location = new System.Drawing.Point(437, 664);
            this.btnAyarlar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(125, 75);
            this.btnAyarlar.TabIndex = 131;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSiparis.BackgroundImage = global::ProjeFinal.Properties.Resources.fork_and_knife_with_plate_icon;
            this.btnSiparis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparis.Location = new System.Drawing.Point(187, 664);
            this.btnSiparis.Margin = new System.Windows.Forms.Padding(0);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(125, 75);
            this.btnSiparis.TabIndex = 133;
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
            this.btnGeriDon.TabIndex = 127;
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
            this.btnCikis.TabIndex = 128;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.ContextMenuStrip = this.cntmnsRightClick;
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblToplamOdeme);
            this.Controls.Add(this.lblIndirimTutari);
            this.Controls.Add(this.lblAraToplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdemeOnayla);
            this.Controls.Add(this.btnOdemeIptal);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtAraToplam);
            this.Controls.Add(this.txtIndirim);
            this.Controls.Add(this.lblMasaNum);
            this.Controls.Add(this.lblKullanan);
            this.Controls.Add(this.lblKullanici);
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
            this.Controls.Add(this.lblMasa);
            this.Controls.Add(this.lstSiparisler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOdeme";
            this.Load += new System.EventHandler(this.frmOdeme_Load);
            this.cntmnsRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMasaNum;
        private System.Windows.Forms.Label lblKullanan;
        private System.Windows.Forms.Label lblKullanici;
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
        private System.Windows.Forms.Label lblMasa;
        public System.Windows.Forms.ListView lstSiparisler;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader clmUrunAd;
        private System.Windows.Forms.ColumnHeader clmUrunAdet;
        private System.Windows.Forms.ColumnHeader clmUrunFiyat;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblToplamOdeme;
        private System.Windows.Forms.Label lblIndirimTutari;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdemeOnayla;
        private System.Windows.Forms.Button btnOdemeIptal;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtAraToplam;
        private System.Windows.Forms.TextBox txtIndirim;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip cntmnsRightClick;
        private System.Windows.Forms.ToolStripMenuItem toolAsagi;
        private System.Windows.Forms.ToolStripMenuItem toolKapat;
        private System.Windows.Forms.ToolStripMenuItem toolRestart;
    }
}