
namespace ProjeFinal
{
    partial class frmSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparis));
            this.txtToplamTutarYazi = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnOde = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.lblMasa = new System.Windows.Forms.Label();
            this.lstSiparisler = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUrunAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUrunAdet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUrunFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlNumAdet = new System.Windows.Forms.Panel();
            this.txtNumAdet = new System.Windows.Forms.TextBox();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNumC = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblKullanan = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnKahvaltiliklar = new System.Windows.Forms.Button();
            this.btnTatlilar = new System.Windows.Forms.Button();
            this.btnIcecekler = new System.Windows.Forms.Button();
            this.btnAnaYemekler = new System.Windows.Forms.Button();
            this.lstYemekListe = new System.Windows.Forms.ListView();
            this.yemekId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yemekKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yemekAdı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yemekFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMasaNum = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnMasaKapat = new System.Windows.Forms.Button();
            this.cntmnsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolAsagi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnKilit = new System.Windows.Forms.Button();
            this.btnYemekMenu = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMasaAc = new System.Windows.Forms.Button();
            this.pnlNumAdet.SuspendLayout();
            this.cntmnsRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtToplamTutarYazi
            // 
            this.txtToplamTutarYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutarYazi.Location = new System.Drawing.Point(12, 449);
            this.txtToplamTutarYazi.Margin = new System.Windows.Forms.Padding(0);
            this.txtToplamTutarYazi.Multiline = true;
            this.txtToplamTutarYazi.Name = "txtToplamTutarYazi";
            this.txtToplamTutarYazi.ReadOnly = true;
            this.txtToplamTutarYazi.Size = new System.Drawing.Size(171, 39);
            this.txtToplamTutarYazi.TabIndex = 46;
            this.txtToplamTutarYazi.Text = "Toplam Tutar:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.White;
            this.lblToplamTutar.Location = new System.Drawing.Point(182, 449);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(93, 39);
            this.lblToplamTutar.TabIndex = 45;
            this.lblToplamTutar.Text = "0000";
            this.lblToplamTutar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOde
            // 
            this.btnOde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(152, 488);
            this.btnOde.Margin = new System.Windows.Forms.Padding(0);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(140, 70);
            this.btnOde.TabIndex = 42;
            this.btnOde.Text = "Öde";
            this.btnOde.UseVisualStyleBackColor = false;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(880, 309);
            this.btnSil.Margin = new System.Windows.Forms.Padding(0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 70);
            this.btnSil.TabIndex = 43;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.Lime;
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(12, 488);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(0);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(140, 70);
            this.btnOnayla.TabIndex = 44;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // lblMasa
            // 
            this.lblMasa.AutoSize = true;
            this.lblMasa.BackColor = System.Drawing.Color.Transparent;
            this.lblMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasa.ForeColor = System.Drawing.Color.White;
            this.lblMasa.Location = new System.Drawing.Point(62, 9);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(134, 46);
            this.lblMasa.TabIndex = 41;
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
            this.lstSiparisler.Size = new System.Drawing.Size(280, 359);
            this.lstSiparisler.TabIndex = 40;
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
            this.clmUrunAd.Width = 152;
            // 
            // clmUrunAdet
            // 
            this.clmUrunAdet.Text = "Adet";
            this.clmUrunAdet.Width = 36;
            // 
            // clmUrunFiyat
            // 
            this.clmUrunFiyat.Text = "Fiyat";
            this.clmUrunFiyat.Width = 68;
            // 
            // pnlNumAdet
            // 
            this.pnlNumAdet.BackColor = System.Drawing.Color.LightGray;
            this.pnlNumAdet.Controls.Add(this.txtNumAdet);
            this.pnlNumAdet.Location = new System.Drawing.Point(938, 488);
            this.pnlNumAdet.Name = "pnlNumAdet";
            this.pnlNumAdet.Size = new System.Drawing.Size(62, 70);
            this.pnlNumAdet.TabIndex = 58;
            // 
            // txtNumAdet
            // 
            this.txtNumAdet.BackColor = System.Drawing.Color.LightGray;
            this.txtNumAdet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumAdet.Location = new System.Drawing.Point(0, 22);
            this.txtNumAdet.Name = "txtNumAdet";
            this.txtNumAdet.ReadOnly = true;
            this.txtNumAdet.Size = new System.Drawing.Size(62, 16);
            this.txtNumAdet.TabIndex = 0;
            this.txtNumAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum0.Location = new System.Drawing.Point(822, 488);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(0);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(58, 70);
            this.btnNum0.TabIndex = 47;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum5.Location = new System.Drawing.Point(532, 488);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(0);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(58, 70);
            this.btnNum5.TabIndex = 48;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum7.Location = new System.Drawing.Point(648, 488);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(0);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(58, 70);
            this.btnNum7.TabIndex = 49;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum8.Location = new System.Drawing.Point(706, 488);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(0);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(58, 70);
            this.btnNum8.TabIndex = 50;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum2.Location = new System.Drawing.Point(358, 488);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(0);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(58, 70);
            this.btnNum2.TabIndex = 51;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNumC
            // 
            this.btnNumC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNumC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNumC.Location = new System.Drawing.Point(880, 488);
            this.btnNumC.Margin = new System.Windows.Forms.Padding(0);
            this.btnNumC.Name = "btnNumC";
            this.btnNumC.Size = new System.Drawing.Size(58, 70);
            this.btnNumC.TabIndex = 52;
            this.btnNumC.Text = "C";
            this.btnNumC.UseVisualStyleBackColor = false;
            this.btnNumC.Click += new System.EventHandler(this.btnNumC_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum3.Location = new System.Drawing.Point(416, 488);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(0);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(58, 70);
            this.btnNum3.TabIndex = 53;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum9.Location = new System.Drawing.Point(764, 488);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(0);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(58, 70);
            this.btnNum9.TabIndex = 54;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum6.Location = new System.Drawing.Point(590, 488);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(0);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(58, 70);
            this.btnNum6.TabIndex = 55;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum4.Location = new System.Drawing.Point(474, 488);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(0);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(58, 70);
            this.btnNum4.TabIndex = 56;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNum1.Location = new System.Drawing.Point(300, 488);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(0);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(58, 70);
            this.btnNum1.TabIndex = 57;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.BackColor = System.Drawing.Color.Transparent;
            this.lblGun.ForeColor = System.Drawing.Color.Yellow;
            this.lblGun.Location = new System.Drawing.Point(930, 695);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(13, 13);
            this.lblGun.TabIndex = 97;
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
            this.lblTarih.TabIndex = 95;
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
            this.lblSaat.TabIndex = 96;
            this.lblSaat.Text = "b";
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
            this.lblKullanan.TabIndex = 100;
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
            this.lblKullanici.TabIndex = 99;
            this.lblKullanici.Text = "kullanıcıid\r\n";
            // 
            // btnKahvaltiliklar
            // 
            this.btnKahvaltiliklar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnKahvaltiliklar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKahvaltiliklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKahvaltiliklar.Location = new System.Drawing.Point(520, 60);
            this.btnKahvaltiliklar.Margin = new System.Windows.Forms.Padding(0);
            this.btnKahvaltiliklar.Name = "btnKahvaltiliklar";
            this.btnKahvaltiliklar.Size = new System.Drawing.Size(110, 30);
            this.btnKahvaltiliklar.TabIndex = 101;
            this.btnKahvaltiliklar.Text = "KAHVALTILIKLAR";
            this.btnKahvaltiliklar.UseVisualStyleBackColor = false;
            this.btnKahvaltiliklar.Click += new System.EventHandler(this.btnKahvaltiliklar_Click);
            // 
            // btnTatlilar
            // 
            this.btnTatlilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTatlilar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTatlilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTatlilar.Location = new System.Drawing.Point(630, 60);
            this.btnTatlilar.Margin = new System.Windows.Forms.Padding(0);
            this.btnTatlilar.Name = "btnTatlilar";
            this.btnTatlilar.Size = new System.Drawing.Size(110, 30);
            this.btnTatlilar.TabIndex = 102;
            this.btnTatlilar.Text = "TATLILAR";
            this.btnTatlilar.UseVisualStyleBackColor = false;
            this.btnTatlilar.Click += new System.EventHandler(this.btnTatlilar_Click);
            // 
            // btnIcecekler
            // 
            this.btnIcecekler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIcecekler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIcecekler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIcecekler.Location = new System.Drawing.Point(410, 60);
            this.btnIcecekler.Margin = new System.Windows.Forms.Padding(0);
            this.btnIcecekler.Name = "btnIcecekler";
            this.btnIcecekler.Size = new System.Drawing.Size(110, 30);
            this.btnIcecekler.TabIndex = 104;
            this.btnIcecekler.Text = "İÇECEKLER";
            this.btnIcecekler.UseVisualStyleBackColor = false;
            this.btnIcecekler.Click += new System.EventHandler(this.btnIcecekler_Click);
            // 
            // btnAnaYemekler
            // 
            this.btnAnaYemekler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAnaYemekler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnaYemekler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaYemekler.Location = new System.Drawing.Point(300, 60);
            this.btnAnaYemekler.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnaYemekler.Name = "btnAnaYemekler";
            this.btnAnaYemekler.Size = new System.Drawing.Size(110, 30);
            this.btnAnaYemekler.TabIndex = 103;
            this.btnAnaYemekler.Text = "ANAYEMEKLER";
            this.btnAnaYemekler.UseVisualStyleBackColor = false;
            this.btnAnaYemekler.Click += new System.EventHandler(this.btnAnaYemekler_Click);
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
            this.lstYemekListe.Location = new System.Drawing.Point(300, 90);
            this.lstYemekListe.Margin = new System.Windows.Forms.Padding(0);
            this.lstYemekListe.Name = "lstYemekListe";
            this.lstYemekListe.Size = new System.Drawing.Size(440, 359);
            this.lstYemekListe.TabIndex = 105;
            this.lstYemekListe.UseCompatibleStateImageBehavior = false;
            this.lstYemekListe.View = System.Windows.Forms.View.Details;
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
            // lblMasaNum
            // 
            this.lblMasaNum.AutoSize = true;
            this.lblMasaNum.BackColor = System.Drawing.Color.Transparent;
            this.lblMasaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNum.ForeColor = System.Drawing.Color.White;
            this.lblMasaNum.Location = new System.Drawing.Point(187, 9);
            this.lblMasaNum.Name = "lblMasaNum";
            this.lblMasaNum.Size = new System.Drawing.Size(65, 46);
            this.lblMasaNum.TabIndex = 106;
            this.lblMasaNum.Text = "no";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(764, 309);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(0);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(96, 70);
            this.btnEkle.TabIndex = 107;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnMasaKapat
            // 
            this.btnMasaKapat.BackColor = System.Drawing.Color.Red;
            this.btnMasaKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMasaKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaKapat.Location = new System.Drawing.Point(520, 9);
            this.btnMasaKapat.Margin = new System.Windows.Forms.Padding(0);
            this.btnMasaKapat.Name = "btnMasaKapat";
            this.btnMasaKapat.Size = new System.Drawing.Size(220, 51);
            this.btnMasaKapat.TabIndex = 108;
            this.btnMasaKapat.Text = "Masayı Kapat";
            this.btnMasaKapat.UseVisualStyleBackColor = false;
            this.btnMasaKapat.Click += new System.EventHandler(this.btnMasaKapat_Click);
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
            this.btnPersoneller.TabIndex = 98;
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
            this.btnKilit.TabIndex = 90;
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
            this.btnYemekMenu.TabIndex = 91;
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
            this.btnAyarlar.TabIndex = 92;
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
            this.btnSiparis.TabIndex = 94;
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
            this.btnGeriDon.TabIndex = 88;
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
            this.btnCikis.TabIndex = 89;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.BackColor = System.Drawing.Color.Olive;
            this.btnMasaAc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMasaAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaAc.Location = new System.Drawing.Point(300, 9);
            this.btnMasaAc.Margin = new System.Windows.Forms.Padding(0);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(220, 51);
            this.btnMasaAc.TabIndex = 109;
            this.btnMasaAc.Text = "Masayı Aç";
            this.btnMasaAc.UseVisualStyleBackColor = false;
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.ContextMenuStrip = this.cntmnsRightClick;
            this.Controls.Add(this.btnMasaAc);
            this.Controls.Add(this.btnMasaKapat);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblMasaNum);
            this.Controls.Add(this.lstYemekListe);
            this.Controls.Add(this.btnIcecekler);
            this.Controls.Add(this.btnAnaYemekler);
            this.Controls.Add(this.btnTatlilar);
            this.Controls.Add(this.btnKahvaltiliklar);
            this.Controls.Add(this.lblKullanan);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnPersoneller);
            this.Controls.Add(this.pnlNumAdet);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnKilit);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnYemekMenu);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnNumC);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.txtToplamTutarYazi);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.lblMasa);
            this.Controls.Add(this.lstSiparisler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSiparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSiparis";
            this.Load += new System.EventHandler(this.frmSiparis_Load);
            this.pnlNumAdet.ResumeLayout(false);
            this.pnlNumAdet.PerformLayout();
            this.cntmnsRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToplamTutarYazi;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label lblMasa;
        public System.Windows.Forms.ListView lstSiparisler;
        private System.Windows.Forms.ColumnHeader clmUrunAd;
        private System.Windows.Forms.ColumnHeader clmUrunAdet;
        private System.Windows.Forms.ColumnHeader clmUrunFiyat;
        private System.Windows.Forms.Panel pnlNumAdet;
        private System.Windows.Forms.TextBox txtNumAdet;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNumC;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum1;
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
        private System.Windows.Forms.Label lblKullanan;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnKahvaltiliklar;
        private System.Windows.Forms.Button btnTatlilar;
        private System.Windows.Forms.Button btnIcecekler;
        private System.Windows.Forms.Button btnAnaYemekler;
        private System.Windows.Forms.ListView lstYemekListe;
        private System.Windows.Forms.ColumnHeader yemekId;
        private System.Windows.Forms.ColumnHeader yemekKategori;
        private System.Windows.Forms.ColumnHeader yemekAdı;
        private System.Windows.Forms.ColumnHeader yemekFiyat;
        private System.Windows.Forms.Label lblMasaNum;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnMasaKapat;
        private System.Windows.Forms.ContextMenuStrip cntmnsRightClick;
        private System.Windows.Forms.ToolStripMenuItem toolAsagi;
        private System.Windows.Forms.ToolStripMenuItem toolKapat;
        private System.Windows.Forms.ToolStripMenuItem toolRestart;
        private System.Windows.Forms.Button btnMasaAc;
    }
}