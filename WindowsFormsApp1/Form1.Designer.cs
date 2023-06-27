namespace WindowsFormsApp1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button8 = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.Chuyen = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.File = new System.Windows.Forms.Button();
            this.Ky = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.Kiemtrachuky = new System.Windows.Forms.Button();
            this.Filechuky = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Filevanban = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.Luu);
            this.splitContainer1.Panel1.Controls.Add(this.Chuyen);
            this.splitContainer1.Panel1.Controls.Add(this.txt2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.File);
            this.splitContainer1.Panel1.Controls.Add(this.Ky);
            this.splitContainer1.Panel1.Controls.Add(this.txt1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txt5);
            this.splitContainer1.Panel2.Controls.Add(this.Kiemtrachuky);
            this.splitContainer1.Panel2.Controls.Add(this.Filechuky);
            this.splitContainer1.Panel2.Controls.Add(this.txt4);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.Filevanban);
            this.splitContainer1.Panel2.Controls.Add(this.txt3);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(998, 545);
            this.splitContainer1.SplitterDistance = 533;
            this.splitContainer1.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(522, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(13, 539);
            this.button8.TabIndex = 10;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // Luu
            // 
            this.Luu.BackColor = System.Drawing.SystemColors.Highlight;
            this.Luu.Location = new System.Drawing.Point(344, 389);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(95, 55);
            this.Luu.TabIndex = 9;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = false;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // Chuyen
            // 
            this.Chuyen.BackColor = System.Drawing.SystemColors.Highlight;
            this.Chuyen.Location = new System.Drawing.Point(344, 330);
            this.Chuyen.Name = "Chuyen";
            this.Chuyen.Size = new System.Drawing.Size(95, 53);
            this.Chuyen.TabIndex = 8;
            this.Chuyen.Text = "Chuyển";
            this.Chuyen.UseVisualStyleBackColor = false;
            this.Chuyen.Click += new System.EventHandler(this.Chuyen_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(138, 308);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(200, 136);
            this.txt2.TabIndex = 7;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chữ ký:";
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.SystemColors.Highlight;
            this.File.Location = new System.Drawing.Point(344, 95);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(75, 70);
            this.File.TabIndex = 5;
            this.File.Text = "File";
            this.File.UseVisualStyleBackColor = false;
            this.File.Click += new System.EventHandler(this.File_Click);
            // 
            // Ky
            // 
            this.Ky.BackColor = System.Drawing.SystemColors.Highlight;
            this.Ky.Location = new System.Drawing.Point(197, 204);
            this.Ky.Name = "Ky";
            this.Ky.Size = new System.Drawing.Size(95, 65);
            this.Ky.TabIndex = 4;
            this.Ky.Text = "Ký";
            this.Ky.UseVisualStyleBackColor = false;
            this.Ky.Click += new System.EventHandler(this.Ky_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(138, 92);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(200, 96);
            this.txt1.TabIndex = 3;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phát sinh chữ ký";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Văn bản ký:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thông báo:";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(132, 445);
            this.txt5.Multiline = true;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(214, 41);
            this.txt5.TabIndex = 11;
            this.txt5.TextChanged += new System.EventHandler(this.txt5_TextChanged);
            // 
            // Kiemtrachuky
            // 
            this.Kiemtrachuky.BackColor = System.Drawing.SystemColors.Highlight;
            this.Kiemtrachuky.Location = new System.Drawing.Point(176, 347);
            this.Kiemtrachuky.Name = "Kiemtrachuky";
            this.Kiemtrachuky.Size = new System.Drawing.Size(112, 70);
            this.Kiemtrachuky.TabIndex = 10;
            this.Kiemtrachuky.Text = "Kiểm tra chữ ký\r\n";
            this.Kiemtrachuky.UseVisualStyleBackColor = false;
            this.Kiemtrachuky.Click += new System.EventHandler(this.button7_Click);
            // 
            // Filechuky
            // 
            this.Filechuky.BackColor = System.Drawing.SystemColors.Highlight;
            this.Filechuky.Location = new System.Drawing.Point(359, 237);
            this.Filechuky.Name = "Filechuky";
            this.Filechuky.Size = new System.Drawing.Size(93, 70);
            this.Filechuky.TabIndex = 9;
            this.Filechuky.Text = "File chữ ký";
            this.Filechuky.UseVisualStyleBackColor = false;
            this.Filechuky.Click += new System.EventHandler(this.Filechuky_Click);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(132, 204);
            this.txt4.Multiline = true;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(211, 125);
            this.txt4.TabIndex = 8;
            this.txt4.TextChanged += new System.EventHandler(this.txt4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chữ ký:";
            // 
            // Filevanban
            // 
            this.Filevanban.BackColor = System.Drawing.SystemColors.Highlight;
            this.Filevanban.Location = new System.Drawing.Point(349, 97);
            this.Filevanban.Name = "Filevanban";
            this.Filevanban.Size = new System.Drawing.Size(93, 70);
            this.Filevanban.TabIndex = 6;
            this.Filevanban.Text = "File văn bản";
            this.Filevanban.UseVisualStyleBackColor = false;
            this.Filevanban.Click += new System.EventHandler(this.Filevanban_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(149, 95);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(194, 93);
            this.txt3.TabIndex = 4;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Văn bản ký:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kiểm tra chữ ký";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 552);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Kiểm Tra Chữ Kí";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.Button Chuyen;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button File;
        private System.Windows.Forms.Button Ky;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Kiemtrachuky;
        private System.Windows.Forms.Button Filechuky;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Filevanban;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txt1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

