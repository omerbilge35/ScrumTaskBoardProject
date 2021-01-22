
namespace ScrumTaskBoardProject
{
    partial class TaskBoard
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
            this.Yapilacak = new System.Windows.Forms.ListBox();
            this.Yapiliyor = new System.Windows.Forms.ListBox();
            this.Duzenleme = new System.Windows.Forms.ListBox();
            this.Kontrol = new System.Windows.Forms.ListBox();
            this.Bitti = new System.Windows.Forms.ListBox();
            this.btn_teknikkartgeri = new System.Windows.Forms.Button();
            this.txt_isleritaskboardaat = new System.Windows.Forms.TextBox();
            this.lbl_yapilacaktext = new System.Windows.Forms.Label();
            this.lbl_yapiliyortext = new System.Windows.Forms.Label();
            this.lbl_duzenlemetext = new System.Windows.Forms.Label();
            this.lbl_kontroltext = new System.Windows.Forms.Label();
            this.lbl_bittitext = new System.Windows.Forms.Label();
            this.txt_taskboardisid1 = new System.Windows.Forms.TextBox();
            this.txt_taskboardisid2 = new System.Windows.Forms.TextBox();
            this.txt_taskboardisid3 = new System.Windows.Forms.TextBox();
            this.txt_taskboardisid4 = new System.Windows.Forms.TextBox();
            this.txt_taskboardisid5 = new System.Windows.Forms.TextBox();
            this.txt_taskboardisid6 = new System.Windows.Forms.TextBox();
            this.txt_taskboardisid7 = new System.Windows.Forms.TextBox();
            this.btn_islerigosteregerigit = new System.Windows.Forms.Button();
            this.btn_taskboardkaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Yapilacak
            // 
            this.Yapilacak.AllowDrop = true;
            this.Yapilacak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yapilacak.FormattingEnabled = true;
            this.Yapilacak.ItemHeight = 20;
            this.Yapilacak.Location = new System.Drawing.Point(97, 84);
            this.Yapilacak.Name = "Yapilacak";
            this.Yapilacak.Size = new System.Drawing.Size(171, 444);
            this.Yapilacak.TabIndex = 0;
            this.Yapilacak.SelectedIndexChanged += new System.EventHandler(this.Yapilacak_SelectedIndexChanged);
            this.Yapilacak.DragDrop += new System.Windows.Forms.DragEventHandler(this.Yapilacak_DragDrop);
            this.Yapilacak.DragEnter += new System.Windows.Forms.DragEventHandler(this.Yapilacak_DragEnter);
            this.Yapilacak.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Yapilacak_MouseDown);
            // 
            // Yapiliyor
            // 
            this.Yapiliyor.AllowDrop = true;
            this.Yapiliyor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yapiliyor.FormattingEnabled = true;
            this.Yapiliyor.ItemHeight = 20;
            this.Yapiliyor.Location = new System.Drawing.Point(310, 84);
            this.Yapiliyor.Name = "Yapiliyor";
            this.Yapiliyor.Size = new System.Drawing.Size(171, 444);
            this.Yapiliyor.TabIndex = 1;
            this.Yapiliyor.DragDrop += new System.Windows.Forms.DragEventHandler(this.Yapiliyor_DragDrop);
            this.Yapiliyor.DragEnter += new System.Windows.Forms.DragEventHandler(this.Yapiliyor_DragEnter);
            this.Yapiliyor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Yapiliyor_MouseDown);
            // 
            // Duzenleme
            // 
            this.Duzenleme.AllowDrop = true;
            this.Duzenleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Duzenleme.FormattingEnabled = true;
            this.Duzenleme.ItemHeight = 20;
            this.Duzenleme.Location = new System.Drawing.Point(535, 84);
            this.Duzenleme.Name = "Duzenleme";
            this.Duzenleme.Size = new System.Drawing.Size(171, 444);
            this.Duzenleme.TabIndex = 2;
            this.Duzenleme.DragDrop += new System.Windows.Forms.DragEventHandler(this.Duzenleme_DragDrop);
            this.Duzenleme.DragEnter += new System.Windows.Forms.DragEventHandler(this.Duzenleme_DragEnter);
            this.Duzenleme.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Duzenleme_MouseDown);
            // 
            // Kontrol
            // 
            this.Kontrol.AllowDrop = true;
            this.Kontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kontrol.FormattingEnabled = true;
            this.Kontrol.ItemHeight = 20;
            this.Kontrol.Location = new System.Drawing.Point(750, 84);
            this.Kontrol.Name = "Kontrol";
            this.Kontrol.Size = new System.Drawing.Size(171, 444);
            this.Kontrol.TabIndex = 3;
            this.Kontrol.DragDrop += new System.Windows.Forms.DragEventHandler(this.Kontrol_DragDrop);
            this.Kontrol.DragEnter += new System.Windows.Forms.DragEventHandler(this.Kontrol_DragEnter);
            this.Kontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kontrol_MouseDown);
            // 
            // Bitti
            // 
            this.Bitti.AllowDrop = true;
            this.Bitti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bitti.FormattingEnabled = true;
            this.Bitti.ItemHeight = 20;
            this.Bitti.Location = new System.Drawing.Point(968, 84);
            this.Bitti.Name = "Bitti";
            this.Bitti.Size = new System.Drawing.Size(171, 444);
            this.Bitti.TabIndex = 4;
            this.Bitti.DragDrop += new System.Windows.Forms.DragEventHandler(this.Bitti_DragDrop);
            this.Bitti.DragEnter += new System.Windows.Forms.DragEventHandler(this.Bitti_DragEnter);
            this.Bitti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bitti_MouseDown);
            // 
            // btn_teknikkartgeri
            // 
            this.btn_teknikkartgeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_teknikkartgeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_teknikkartgeri.Image = global::ScrumTaskBoardProject.Properties.Resources.go_back_arrow;
            this.btn_teknikkartgeri.Location = new System.Drawing.Point(23, 561);
            this.btn_teknikkartgeri.Name = "btn_teknikkartgeri";
            this.btn_teknikkartgeri.Size = new System.Drawing.Size(80, 70);
            this.btn_teknikkartgeri.TabIndex = 6;
            this.btn_teknikkartgeri.UseVisualStyleBackColor = true;
            this.btn_teknikkartgeri.Visible = false;
            this.btn_teknikkartgeri.Click += new System.EventHandler(this.btn_teknikkartgeri_Click);
            // 
            // txt_isleritaskboardaat
            // 
            this.txt_isleritaskboardaat.Location = new System.Drawing.Point(203, 13);
            this.txt_isleritaskboardaat.Name = "txt_isleritaskboardaat";
            this.txt_isleritaskboardaat.Size = new System.Drawing.Size(100, 20);
            this.txt_isleritaskboardaat.TabIndex = 8;
            this.txt_isleritaskboardaat.Visible = false;
            // 
            // lbl_yapilacaktext
            // 
            this.lbl_yapilacaktext.AutoSize = true;
            this.lbl_yapilacaktext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yapilacaktext.Location = new System.Drawing.Point(127, 56);
            this.lbl_yapilacaktext.Name = "lbl_yapilacaktext";
            this.lbl_yapilacaktext.Size = new System.Drawing.Size(106, 25);
            this.lbl_yapilacaktext.TabIndex = 9;
            this.lbl_yapilacaktext.Text = "Yapılacak";
            // 
            // lbl_yapiliyortext
            // 
            this.lbl_yapiliyortext.AutoSize = true;
            this.lbl_yapiliyortext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yapiliyortext.Location = new System.Drawing.Point(351, 56);
            this.lbl_yapiliyortext.Name = "lbl_yapiliyortext";
            this.lbl_yapiliyortext.Size = new System.Drawing.Size(95, 25);
            this.lbl_yapiliyortext.TabIndex = 10;
            this.lbl_yapiliyortext.Text = "Yapılıyor";
            // 
            // lbl_duzenlemetext
            // 
            this.lbl_duzenlemetext.AutoSize = true;
            this.lbl_duzenlemetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_duzenlemetext.Location = new System.Drawing.Point(558, 56);
            this.lbl_duzenlemetext.Name = "lbl_duzenlemetext";
            this.lbl_duzenlemetext.Size = new System.Drawing.Size(120, 25);
            this.lbl_duzenlemetext.TabIndex = 11;
            this.lbl_duzenlemetext.Text = "Düzenleme";
            // 
            // lbl_kontroltext
            // 
            this.lbl_kontroltext.AutoSize = true;
            this.lbl_kontroltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kontroltext.Location = new System.Drawing.Point(790, 56);
            this.lbl_kontroltext.Name = "lbl_kontroltext";
            this.lbl_kontroltext.Size = new System.Drawing.Size(81, 25);
            this.lbl_kontroltext.TabIndex = 12;
            this.lbl_kontroltext.Text = "Kontrol";
            // 
            // lbl_bittitext
            // 
            this.lbl_bittitext.AutoSize = true;
            this.lbl_bittitext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bittitext.Location = new System.Drawing.Point(1031, 56);
            this.lbl_bittitext.Name = "lbl_bittitext";
            this.lbl_bittitext.Size = new System.Drawing.Size(48, 25);
            this.lbl_bittitext.TabIndex = 13;
            this.lbl_bittitext.Text = "Bitti";
            // 
            // txt_taskboardisid1
            // 
            this.txt_taskboardisid1.Location = new System.Drawing.Point(203, 13);
            this.txt_taskboardisid1.Name = "txt_taskboardisid1";
            this.txt_taskboardisid1.Size = new System.Drawing.Size(100, 20);
            this.txt_taskboardisid1.TabIndex = 14;
            this.txt_taskboardisid1.Visible = false;
            // 
            // txt_taskboardisid2
            // 
            this.txt_taskboardisid2.Location = new System.Drawing.Point(203, 13);
            this.txt_taskboardisid2.Name = "txt_taskboardisid2";
            this.txt_taskboardisid2.Size = new System.Drawing.Size(100, 20);
            this.txt_taskboardisid2.TabIndex = 15;
            this.txt_taskboardisid2.Visible = false;
            // 
            // txt_taskboardisid3
            // 
            this.txt_taskboardisid3.Location = new System.Drawing.Point(203, 13);
            this.txt_taskboardisid3.Name = "txt_taskboardisid3";
            this.txt_taskboardisid3.Size = new System.Drawing.Size(100, 20);
            this.txt_taskboardisid3.TabIndex = 16;
            this.txt_taskboardisid3.Visible = false;
            // 
            // txt_taskboardisid4
            // 
            this.txt_taskboardisid4.Location = new System.Drawing.Point(203, 13);
            this.txt_taskboardisid4.Name = "txt_taskboardisid4";
            this.txt_taskboardisid4.Size = new System.Drawing.Size(100, 20);
            this.txt_taskboardisid4.TabIndex = 17;
            this.txt_taskboardisid4.Visible = false;
            // 
            // txt_taskboardisid5
            // 
            this.txt_taskboardisid5.Location = new System.Drawing.Point(203, 13);
            this.txt_taskboardisid5.Name = "txt_taskboardisid5";
            this.txt_taskboardisid5.Size = new System.Drawing.Size(100, 20);
            this.txt_taskboardisid5.TabIndex = 18;
            this.txt_taskboardisid5.Visible = false;
            // 
            // txt_taskboardisid6
            // 
            this.txt_taskboardisid6.Location = new System.Drawing.Point(203, 13);
            this.txt_taskboardisid6.Name = "txt_taskboardisid6";
            this.txt_taskboardisid6.Size = new System.Drawing.Size(100, 20);
            this.txt_taskboardisid6.TabIndex = 19;
            this.txt_taskboardisid6.Visible = false;
            // 
            // txt_taskboardisid7
            // 
            this.txt_taskboardisid7.Location = new System.Drawing.Point(203, 13);
            this.txt_taskboardisid7.Name = "txt_taskboardisid7";
            this.txt_taskboardisid7.Size = new System.Drawing.Size(100, 20);
            this.txt_taskboardisid7.TabIndex = 20;
            this.txt_taskboardisid7.Visible = false;
            // 
            // btn_islerigosteregerigit
            // 
            this.btn_islerigosteregerigit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_islerigosteregerigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_islerigosteregerigit.Image = global::ScrumTaskBoardProject.Properties.Resources.go_back_arrow;
            this.btn_islerigosteregerigit.Location = new System.Drawing.Point(23, 561);
            this.btn_islerigosteregerigit.Name = "btn_islerigosteregerigit";
            this.btn_islerigosteregerigit.Size = new System.Drawing.Size(80, 70);
            this.btn_islerigosteregerigit.TabIndex = 7;
            this.btn_islerigosteregerigit.UseVisualStyleBackColor = true;
            this.btn_islerigosteregerigit.Visible = false;
            this.btn_islerigosteregerigit.Click += new System.EventHandler(this.btn_islerigosteregerigit_Click);
            // 
            // btn_taskboardkaydet
            // 
            this.btn_taskboardkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_taskboardkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_taskboardkaydet.Image = global::ScrumTaskBoardProject.Properties.Resources.floppy_disk;
            this.btn_taskboardkaydet.Location = new System.Drawing.Point(1141, 561);
            this.btn_taskboardkaydet.Name = "btn_taskboardkaydet";
            this.btn_taskboardkaydet.Size = new System.Drawing.Size(87, 70);
            this.btn_taskboardkaydet.TabIndex = 5;
            this.btn_taskboardkaydet.UseVisualStyleBackColor = true;
            this.btn_taskboardkaydet.Click += new System.EventHandler(this.btn_taskboardkaydet_Click);
            // 
            // TaskBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 654);
            this.Controls.Add(this.txt_taskboardisid7);
            this.Controls.Add(this.txt_taskboardisid6);
            this.Controls.Add(this.txt_taskboardisid5);
            this.Controls.Add(this.txt_taskboardisid4);
            this.Controls.Add(this.txt_taskboardisid3);
            this.Controls.Add(this.txt_taskboardisid2);
            this.Controls.Add(this.txt_taskboardisid1);
            this.Controls.Add(this.lbl_bittitext);
            this.Controls.Add(this.lbl_kontroltext);
            this.Controls.Add(this.lbl_duzenlemetext);
            this.Controls.Add(this.lbl_yapiliyortext);
            this.Controls.Add(this.lbl_yapilacaktext);
            this.Controls.Add(this.txt_isleritaskboardaat);
            this.Controls.Add(this.btn_islerigosteregerigit);
            this.Controls.Add(this.btn_teknikkartgeri);
            this.Controls.Add(this.btn_taskboardkaydet);
            this.Controls.Add(this.Bitti);
            this.Controls.Add(this.Kontrol);
            this.Controls.Add(this.Duzenleme);
            this.Controls.Add(this.Yapiliyor);
            this.Controls.Add(this.Yapilacak);
            this.Name = "TaskBoard";
            this.Text = "DB Yazılım";
            this.Load += new System.EventHandler(this.TaskBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Yapilacak;
        private System.Windows.Forms.ListBox Yapiliyor;
        private System.Windows.Forms.ListBox Duzenleme;
        private System.Windows.Forms.ListBox Kontrol;
        private System.Windows.Forms.ListBox Bitti;
        private System.Windows.Forms.Button btn_taskboardkaydet;
        private System.Windows.Forms.Button btn_teknikkartgeri;
        private System.Windows.Forms.Button btn_islerigosteregerigit;
        private System.Windows.Forms.TextBox txt_isleritaskboardaat;
        private System.Windows.Forms.Label lbl_yapilacaktext;
        private System.Windows.Forms.Label lbl_yapiliyortext;
        private System.Windows.Forms.Label lbl_duzenlemetext;
        private System.Windows.Forms.Label lbl_kontroltext;
        private System.Windows.Forms.Label lbl_bittitext;
        private System.Windows.Forms.TextBox txt_taskboardisid1;
        private System.Windows.Forms.TextBox txt_taskboardisid2;
        private System.Windows.Forms.TextBox txt_taskboardisid3;
        private System.Windows.Forms.TextBox txt_taskboardisid4;
        private System.Windows.Forms.TextBox txt_taskboardisid5;
        private System.Windows.Forms.TextBox txt_taskboardisid6;
        private System.Windows.Forms.TextBox txt_taskboardisid7;
    }
}