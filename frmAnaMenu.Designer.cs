
namespace ProjeFinal
{
    partial class frmAnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaMenu));
            this.lblGun = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cntmnsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolAsagi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblKullanan = new System.Windows.Forms.Label();
            this.toolKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKilit = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnYemekMenu = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
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
            this.lblGun.TabIndex = 18;
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
            this.lblTarih.TabIndex = 16;
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
            this.lblSaat.TabIndex = 17;
            this.lblSaat.Text = "b";
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
            // toolRestart
            // 
            this.toolRestart.Name = "toolRestart";
            this.toolRestart.Size = new System.Drawing.Size(216, 22);
            this.toolRestart.Text = "Uygulamayı Yeniden Başlat";
            this.toolRestart.Click += new System.EventHandler(this.toolRestart_Click);
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
            this.lblKullanici.TabIndex = 21;
            this.lblKullanici.Text = "kullanıcıid\r\n";
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
            this.lblKullanan.TabIndex = 22;
            this.lblKullanan.Text = "Kullanıcı :";
            // 
            // toolKapat
            // 
            this.toolKapat.Name = "toolKapat";
            this.toolKapat.Size = new System.Drawing.Size(216, 22);
            this.toolKapat.Text = "Uygulamayı Kapat";
            this.toolKapat.Click += new System.EventHandler(this.toolKapat_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPersoneller.BackgroundImage = global::ProjeFinal.Properties.Resources.personeller1;
            this.btnPersoneller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPersoneller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersoneller.Location = new System.Drawing.Point(250, 375);
            this.btnPersoneller.Margin = new System.Windows.Forms.Padding(0);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(250, 150);
            this.btnPersoneller.TabIndex = 19;
            this.btnPersoneller.UseVisualStyleBackColor = false;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::ProjeFinal.Properties.Resources.delete_icon;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(9, 666);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 75);
            this.btnCikis.TabIndex = 15;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKilit
            // 
            this.btnKilit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(193)))), ((int)(((byte)(30)))));
            this.btnKilit.BackgroundImage = global::ProjeFinal.Properties.Resources.Lock_icon;
            this.btnKilit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKilit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKilit.Location = new System.Drawing.Point(500, 375);
            this.btnKilit.Margin = new System.Windows.Forms.Padding(0);
            this.btnKilit.Name = "btnKilit";
            this.btnKilit.Size = new System.Drawing.Size(250, 150);
            this.btnKilit.TabIndex = 14;
            this.btnKilit.UseVisualStyleBackColor = false;
            this.btnKilit.Click += new System.EventHandler(this.btnKilit_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.DarkGray;
            this.btnAyarlar.BackgroundImage = global::ProjeFinal.Properties.Resources.settings_icon;
            this.btnAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyarlar.Location = new System.Drawing.Point(623, 225);
            this.btnAyarlar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(250, 150);
            this.btnAyarlar.TabIndex = 13;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnYemekMenu
            // 
            this.btnYemekMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnYemekMenu.BackgroundImage = global::ProjeFinal.Properties.Resources.restaurant_menu;
            this.btnYemekMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYemekMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYemekMenu.Location = new System.Drawing.Point(375, 225);
            this.btnYemekMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnYemekMenu.Name = "btnYemekMenu";
            this.btnYemekMenu.Size = new System.Drawing.Size(250, 150);
            this.btnYemekMenu.TabIndex = 11;
            this.btnYemekMenu.UseVisualStyleBackColor = false;
            this.btnYemekMenu.Click += new System.EventHandler(this.btnYemekMenu_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSiparis.BackgroundImage = global::ProjeFinal.Properties.Resources.fork_and_knife_with_plate_icon;
            this.btnSiparis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparis.Location = new System.Drawing.Point(125, 225);
            this.btnSiparis.Margin = new System.Windows.Forms.Padding(0);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(250, 150);
            this.btnSiparis.TabIndex = 10;
            this.btnSiparis.UseVisualStyleBackColor = false;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.ContextMenuStrip = this.cntmnsRightClick;
            this.Controls.Add(this.lblKullanan);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnPersoneller);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKilit);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnYemekMenu);
            this.Controls.Add(this.btnSiparis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnaMenu";
            this.Load += new System.EventHandler(this.frmAnaMenu_Load);
            this.cntmnsRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKilit;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnYemekMenu;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip cntmnsRightClick;
        private System.Windows.Forms.ToolStripMenuItem toolAsagi;
        private System.Windows.Forms.ToolStripMenuItem toolKapat;
        private System.Windows.Forms.ToolStripMenuItem toolRestart;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblKullanan;
    }
}