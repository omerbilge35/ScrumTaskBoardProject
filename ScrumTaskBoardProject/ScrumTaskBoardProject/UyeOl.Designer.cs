
namespace ScrumTaskBoardProject
{
    partial class UyeOl
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtb_adsoyad = new MetroFramework.Controls.MetroTextBox();
            this.mtb_kullaniciadi = new MetroFramework.Controls.MetroTextBox();
            this.mtb_sifre = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_sifregoster = new System.Windows.Forms.CheckBox();
            this.btn_uyeoltamamla = new System.Windows.Forms.Button();
            this.btn_uyeolgeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(88, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ad Soyad :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(75, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Kullanıcı Adı :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(119, 176);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Şifre :";
            // 
            // mtb_adsoyad
            // 
            this.mtb_adsoyad.Location = new System.Drawing.Point(189, 95);
            this.mtb_adsoyad.Name = "mtb_adsoyad";
            this.mtb_adsoyad.Size = new System.Drawing.Size(215, 23);
            this.mtb_adsoyad.TabIndex = 4;
            this.mtb_adsoyad.Text = "Adınızı Ve Soyadınızı Giriniz";
            this.mtb_adsoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_adsoyad.Click += new System.EventHandler(this.mtb_adsoyad_Click);
            // 
            // mtb_kullaniciadi
            // 
            this.mtb_kullaniciadi.Location = new System.Drawing.Point(189, 134);
            this.mtb_kullaniciadi.Name = "mtb_kullaniciadi";
            this.mtb_kullaniciadi.Size = new System.Drawing.Size(215, 23);
            this.mtb_kullaniciadi.TabIndex = 5;
            this.mtb_kullaniciadi.Text = "Kullanıcı Adınızı Giriniz";
            this.mtb_kullaniciadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_kullaniciadi.Click += new System.EventHandler(this.mtb_kullaniciadi_Click);
            // 
            // mtb_sifre
            // 
            this.mtb_sifre.Location = new System.Drawing.Point(189, 172);
            this.mtb_sifre.Name = "mtb_sifre";
            this.mtb_sifre.Size = new System.Drawing.Size(215, 23);
            this.mtb_sifre.TabIndex = 6;
            this.mtb_sifre.Text = "Şifrenizi Giriniz";
            this.mtb_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_sifre.Click += new System.EventHandler(this.mtb_sifre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_sifregoster);
            this.groupBox1.Controls.Add(this.btn_uyeoltamamla);
            this.groupBox1.Controls.Add(this.btn_uyeolgeri);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.mtb_sifre);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.mtb_kullaniciadi);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.mtb_adsoyad);
            this.groupBox1.Location = new System.Drawing.Point(136, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 323);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cb_sifregoster
            // 
            this.cb_sifregoster.AutoSize = true;
            this.cb_sifregoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_sifregoster.Location = new System.Drawing.Point(410, 176);
            this.cb_sifregoster.Name = "cb_sifregoster";
            this.cb_sifregoster.Size = new System.Drawing.Size(98, 19);
            this.cb_sifregoster.TabIndex = 10;
            this.cb_sifregoster.Text = "Şifreyi Göster";
            this.cb_sifregoster.UseVisualStyleBackColor = true;
            this.cb_sifregoster.CheckedChanged += new System.EventHandler(this.cb_sifregoster_CheckedChanged);
            // 
            // btn_uyeoltamamla
            // 
            this.btn_uyeoltamamla.BackColor = System.Drawing.Color.White;
            this.btn_uyeoltamamla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_uyeoltamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeoltamamla.Image = global::ScrumTaskBoardProject.Properties.Resources.add_user;
            this.btn_uyeoltamamla.Location = new System.Drawing.Point(384, 232);
            this.btn_uyeoltamamla.Name = "btn_uyeoltamamla";
            this.btn_uyeoltamamla.Size = new System.Drawing.Size(92, 70);
            this.btn_uyeoltamamla.TabIndex = 8;
            this.btn_uyeoltamamla.UseVisualStyleBackColor = false;
            this.btn_uyeoltamamla.Click += new System.EventHandler(this.btn_uyeoltamamla_Click_1);
            // 
            // btn_uyeolgeri
            // 
            this.btn_uyeolgeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_uyeolgeri.Image = global::ScrumTaskBoardProject.Properties.Resources.go_back_arrow;
            this.btn_uyeolgeri.Location = new System.Drawing.Point(37, 231);
            this.btn_uyeolgeri.Name = "btn_uyeolgeri";
            this.btn_uyeolgeri.Size = new System.Drawing.Size(92, 71);
            this.btn_uyeolgeri.TabIndex = 9;
            this.btn_uyeolgeri.UseVisualStyleBackColor = true;
            this.btn_uyeolgeri.Click += new System.EventHandler(this.btn_uyeolgeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(203, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "ÜYE OL";
            // 
            // UyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "UyeOl";
            this.Text = "DB Yazılım";
            this.Load += new System.EventHandler(this.UyeOl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtb_adsoyad;
        private MetroFramework.Controls.MetroTextBox mtb_kullaniciadi;
        private MetroFramework.Controls.MetroTextBox mtb_sifre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_uyeolgeri;
        private System.Windows.Forms.Button btn_uyeoltamamla;
        private System.Windows.Forms.CheckBox cb_sifregoster;
    }
}