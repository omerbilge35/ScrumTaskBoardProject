
namespace ScrumTaskBoardProject
{
    partial class Form1
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.lbl_girisekranitext = new System.Windows.Forms.Label();
            this.txt_uyeid = new System.Windows.Forms.TextBox();
            this.lbl_uyeol = new System.Windows.Forms.Label();
            this.lbl_girisyap = new System.Windows.Forms.Label();
            this.btn_uyeol = new System.Windows.Forms.Button();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(101, 143);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Kullanıcı Adı :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(145, 188);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Şifre :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_girisyap);
            this.groupBox1.Controls.Add(this.lbl_uyeol);
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.txt_kullaniciadi);
            this.groupBox1.Controls.Add(this.btn_uyeol);
            this.groupBox1.Controls.Add(this.btn_girisyap);
            this.groupBox1.Controls.Add(this.lbl_girisekranitext);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(176, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 376);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(210, 187);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(180, 20);
            this.txt_sifre.TabIndex = 8;
            this.txt_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sifre.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged);
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(210, 143);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(180, 20);
            this.txt_kullaniciadi.TabIndex = 7;
            this.txt_kullaniciadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_girisekranitext
            // 
            this.lbl_girisekranitext.AutoSize = true;
            this.lbl_girisekranitext.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_girisekranitext.Location = new System.Drawing.Point(188, 45);
            this.lbl_girisekranitext.Name = "lbl_girisekranitext";
            this.lbl_girisekranitext.Size = new System.Drawing.Size(223, 39);
            this.lbl_girisekranitext.TabIndex = 4;
            this.lbl_girisekranitext.Text = "Hoş Geldiniz";
            // 
            // txt_uyeid
            // 
            this.txt_uyeid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_uyeid.Location = new System.Drawing.Point(2, 490);
            this.txt_uyeid.Name = "txt_uyeid";
            this.txt_uyeid.Size = new System.Drawing.Size(92, 20);
            this.txt_uyeid.TabIndex = 5;
            this.txt_uyeid.Visible = false;
            // 
            // lbl_uyeol
            // 
            this.lbl_uyeol.AutoSize = true;
            this.lbl_uyeol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uyeol.Location = new System.Drawing.Point(448, 346);
            this.lbl_uyeol.Name = "lbl_uyeol";
            this.lbl_uyeol.Size = new System.Drawing.Size(56, 20);
            this.lbl_uyeol.TabIndex = 9;
            this.lbl_uyeol.Text = "Üye Ol";
            // 
            // lbl_girisyap
            // 
            this.lbl_girisyap.AutoSize = true;
            this.lbl_girisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_girisyap.Location = new System.Drawing.Point(307, 346);
            this.lbl_girisyap.Name = "lbl_girisyap";
            this.lbl_girisyap.Size = new System.Drawing.Size(74, 20);
            this.lbl_girisyap.TabIndex = 10;
            this.lbl_girisyap.Text = "Giriş Yap";
            // 
            // btn_uyeol
            // 
            this.btn_uyeol.BackColor = System.Drawing.Color.White;
            this.btn_uyeol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_uyeol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeol.Image = global::ScrumTaskBoardProject.Properties.Resources.add_user;
            this.btn_uyeol.Location = new System.Drawing.Point(431, 273);
            this.btn_uyeol.Name = "btn_uyeol";
            this.btn_uyeol.Size = new System.Drawing.Size(92, 70);
            this.btn_uyeol.TabIndex = 6;
            this.btn_uyeol.UseVisualStyleBackColor = false;
            this.btn_uyeol.Click += new System.EventHandler(this.btn_uyeol_Click);
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.BackColor = System.Drawing.Color.White;
            this.btn_girisyap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_girisyap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_girisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisyap.Image = global::ScrumTaskBoardProject.Properties.Resources._in;
            this.btn_girisyap.Location = new System.Drawing.Point(298, 273);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(92, 70);
            this.btn_girisyap.TabIndex = 5;
            this.btn_girisyap.UseVisualStyleBackColor = false;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 511);
            this.Controls.Add(this.txt_uyeid);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "DB Yazılım";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_girisekranitext;
        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.Button btn_uyeol;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.TextBox txt_uyeid;
        private System.Windows.Forms.Label lbl_girisyap;
        private System.Windows.Forms.Label lbl_uyeol;
    }
}

