
namespace ScrumTaskBoardProject
{
    partial class IsleriGoruntule
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
            this.lbl_calismalariniztext = new System.Windows.Forms.Label();
            this.txt_kartnoajani = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_duzenle = new System.Windows.Forms.Label();
            this.lbl_sil = new System.Windows.Forms.Label();
            this.lbl_goruntule = new System.Windows.Forms.Label();
            this.btn_islerdenarayuzedon = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_taskboardduzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_calismalariniztext
            // 
            this.lbl_calismalariniztext.AutoSize = true;
            this.lbl_calismalariniztext.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_calismalariniztext.Location = new System.Drawing.Point(31, 50);
            this.lbl_calismalariniztext.Name = "lbl_calismalariniztext";
            this.lbl_calismalariniztext.Size = new System.Drawing.Size(255, 39);
            this.lbl_calismalariniztext.TabIndex = 2;
            this.lbl_calismalariniztext.Text = "Çalışmalarınız:";
            // 
            // txt_kartnoajani
            // 
            this.txt_kartnoajani.Location = new System.Drawing.Point(697, 11);
            this.txt_kartnoajani.Name = "txt_kartnoajani";
            this.txt_kartnoajani.Size = new System.Drawing.Size(100, 20);
            this.txt_kartnoajani.TabIndex = 5;
            this.txt_kartnoajani.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(710, 218);
            this.dataGridView1.TabIndex = 6;
            // 
            // lbl_duzenle
            // 
            this.lbl_duzenle.AutoSize = true;
            this.lbl_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_duzenle.Location = new System.Drawing.Point(486, 420);
            this.lbl_duzenle.Name = "lbl_duzenle";
            this.lbl_duzenle.Size = new System.Drawing.Size(68, 20);
            this.lbl_duzenle.TabIndex = 9;
            this.lbl_duzenle.Text = "Düzenle";
            // 
            // lbl_sil
            // 
            this.lbl_sil.AutoSize = true;
            this.lbl_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sil.Location = new System.Drawing.Point(609, 420);
            this.lbl_sil.Name = "lbl_sil";
            this.lbl_sil.Size = new System.Drawing.Size(26, 20);
            this.lbl_sil.TabIndex = 10;
            this.lbl_sil.Text = "Sil";
            // 
            // lbl_goruntule
            // 
            this.lbl_goruntule.AutoSize = true;
            this.lbl_goruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_goruntule.Location = new System.Drawing.Point(683, 420);
            this.lbl_goruntule.Name = "lbl_goruntule";
            this.lbl_goruntule.Size = new System.Drawing.Size(80, 20);
            this.lbl_goruntule.TabIndex = 11;
            this.lbl_goruntule.Text = "Görüntüle";
            // 
            // btn_islerdenarayuzedon
            // 
            this.btn_islerdenarayuzedon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_islerdenarayuzedon.Image = global::ScrumTaskBoardProject.Properties.Resources.go_back_arrow;
            this.btn_islerdenarayuzedon.Location = new System.Drawing.Point(23, 344);
            this.btn_islerdenarayuzedon.Name = "btn_islerdenarayuzedon";
            this.btn_islerdenarayuzedon.Size = new System.Drawing.Size(80, 73);
            this.btn_islerdenarayuzedon.TabIndex = 8;
            this.btn_islerdenarayuzedon.UseVisualStyleBackColor = true;
            this.btn_islerdenarayuzedon.Click += new System.EventHandler(this.btn_islerdenarayuzedon_Click_1);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_duzenle.Image = global::ScrumTaskBoardProject.Properties.Resources.edit;
            this.btn_duzenle.Location = new System.Drawing.Point(472, 344);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(98, 73);
            this.btn_duzenle.TabIndex = 4;
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Image = global::ScrumTaskBoardProject.Properties.Resources.delete;
            this.btn_sil.Location = new System.Drawing.Point(576, 344);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(97, 73);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_taskboardduzenle
            // 
            this.btn_taskboardduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_taskboardduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_taskboardduzenle.Image = global::ScrumTaskBoardProject.Properties.Resources.login_square_arrow_button_outline;
            this.btn_taskboardduzenle.Location = new System.Drawing.Point(679, 344);
            this.btn_taskboardduzenle.Name = "btn_taskboardduzenle";
            this.btn_taskboardduzenle.Size = new System.Drawing.Size(84, 73);
            this.btn_taskboardduzenle.TabIndex = 1;
            this.btn_taskboardduzenle.UseVisualStyleBackColor = true;
            this.btn_taskboardduzenle.Click += new System.EventHandler(this.btn_taskboardduzenle_Click);
            // 
            // IsleriGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_goruntule);
            this.Controls.Add(this.lbl_sil);
            this.Controls.Add(this.lbl_duzenle);
            this.Controls.Add(this.btn_islerdenarayuzedon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_kartnoajani);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.lbl_calismalariniztext);
            this.Controls.Add(this.btn_taskboardduzenle);
            this.Name = "IsleriGoruntule";
            this.Text = "DB Yazılım";
            this.Load += new System.EventHandler(this.IsleriGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_taskboardduzenle;
        private System.Windows.Forms.Label lbl_calismalariniztext;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.TextBox txt_kartnoajani;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_islerdenarayuzedon;
        private System.Windows.Forms.Label lbl_duzenle;
        private System.Windows.Forms.Label lbl_sil;
        private System.Windows.Forms.Label lbl_goruntule;
    }
}