
namespace ScrumTaskBoardProject
{
    partial class Arayuz
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
            this.lbl_neyapmakistiyorsunuztext = new System.Windows.Forms.Label();
            this.lbl_yeniisolustur = new System.Windows.Forms.Label();
            this.btn_oncekiislerigoruntule = new System.Windows.Forms.Button();
            this.btn_yeniisolustur = new System.Windows.Forms.Button();
            this.btn_geriii = new System.Windows.Forms.Button();
            this.lbl_islerigoruntule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_neyapmakistiyorsunuztext
            // 
            this.lbl_neyapmakistiyorsunuztext.AutoSize = true;
            this.lbl_neyapmakistiyorsunuztext.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_neyapmakistiyorsunuztext.Location = new System.Drawing.Point(91, 60);
            this.lbl_neyapmakistiyorsunuztext.Name = "lbl_neyapmakistiyorsunuztext";
            this.lbl_neyapmakistiyorsunuztext.Size = new System.Drawing.Size(630, 63);
            this.lbl_neyapmakistiyorsunuztext.TabIndex = 2;
            this.lbl_neyapmakistiyorsunuztext.Text = "Ne yapmak istiyorsunuz?";
            // 
            // lbl_yeniisolustur
            // 
            this.lbl_yeniisolustur.AutoSize = true;
            this.lbl_yeniisolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yeniisolustur.Location = new System.Drawing.Point(185, 280);
            this.lbl_yeniisolustur.Name = "lbl_yeniisolustur";
            this.lbl_yeniisolustur.Size = new System.Drawing.Size(113, 20);
            this.lbl_yeniisolustur.TabIndex = 6;
            this.lbl_yeniisolustur.Text = "Yeni İş Oluştur";
            // 
            // btn_oncekiislerigoruntule
            // 
            this.btn_oncekiislerigoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_oncekiislerigoruntule.Image = global::ScrumTaskBoardProject.Properties.Resources.duplicate;
            this.btn_oncekiislerigoruntule.Location = new System.Drawing.Point(512, 201);
            this.btn_oncekiislerigoruntule.Name = "btn_oncekiislerigoruntule";
            this.btn_oncekiislerigoruntule.Size = new System.Drawing.Size(109, 76);
            this.btn_oncekiislerigoruntule.TabIndex = 7;
            this.btn_oncekiislerigoruntule.UseVisualStyleBackColor = true;
            this.btn_oncekiislerigoruntule.Click += new System.EventHandler(this.btn_oncekiislerigoruntule_Click_1);
            // 
            // btn_yeniisolustur
            // 
            this.btn_yeniisolustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_yeniisolustur.Image = global::ScrumTaskBoardProject.Properties.Resources.add_file;
            this.btn_yeniisolustur.Location = new System.Drawing.Point(189, 201);
            this.btn_yeniisolustur.Name = "btn_yeniisolustur";
            this.btn_yeniisolustur.Size = new System.Drawing.Size(109, 76);
            this.btn_yeniisolustur.TabIndex = 5;
            this.btn_yeniisolustur.UseVisualStyleBackColor = true;
            this.btn_yeniisolustur.Click += new System.EventHandler(this.btn_yeniisolustur_Click_1);
            // 
            // btn_geriii
            // 
            this.btn_geriii.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geriii.Image = global::ScrumTaskBoardProject.Properties.Resources.go_back_arrow;
            this.btn_geriii.Location = new System.Drawing.Point(344, 364);
            this.btn_geriii.Name = "btn_geriii";
            this.btn_geriii.Size = new System.Drawing.Size(97, 63);
            this.btn_geriii.TabIndex = 4;
            this.btn_geriii.UseVisualStyleBackColor = true;
            this.btn_geriii.Click += new System.EventHandler(this.btn_geriii_Click_1);
            // 
            // lbl_islerigoruntule
            // 
            this.lbl_islerigoruntule.AutoSize = true;
            this.lbl_islerigoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_islerigoruntule.Location = new System.Drawing.Point(508, 280);
            this.lbl_islerigoruntule.Name = "lbl_islerigoruntule";
            this.lbl_islerigoruntule.Size = new System.Drawing.Size(117, 20);
            this.lbl_islerigoruntule.TabIndex = 8;
            this.lbl_islerigoruntule.Text = "İşleri Görüntüle";
            // 
            // Arayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_islerigoruntule);
            this.Controls.Add(this.btn_oncekiislerigoruntule);
            this.Controls.Add(this.lbl_yeniisolustur);
            this.Controls.Add(this.btn_yeniisolustur);
            this.Controls.Add(this.btn_geriii);
            this.Controls.Add(this.lbl_neyapmakistiyorsunuztext);
            this.Name = "Arayuz";
            this.Text = "DB Yazılım";
            this.Load += new System.EventHandler(this.Arayuz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_neyapmakistiyorsunuztext;
        private System.Windows.Forms.Button btn_geriii;
        private System.Windows.Forms.Button btn_yeniisolustur;
        private System.Windows.Forms.Label lbl_yeniisolustur;
        private System.Windows.Forms.Button btn_oncekiislerigoruntule;
        private System.Windows.Forms.Label lbl_islerigoruntule;
    }
}