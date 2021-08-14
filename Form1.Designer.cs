namespace KiemtraExcel
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filepath = new System.Windows.Forms.TextBox();
            this.findFolder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SucessList = new System.Windows.Forms.ListBox();
            this.ErrorList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn thư mục cần chỉnh sửa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Chỉnh sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filepath
            // 
            this.filepath.Location = new System.Drawing.Point(162, 58);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(474, 20);
            this.filepath.TabIndex = 5;
            // 
            // findFolder
            // 
            this.findFolder.Location = new System.Drawing.Point(642, 63);
            this.findFolder.Name = "findFolder";
            this.findFolder.Size = new System.Drawing.Size(81, 19);
            this.findFolder.TabIndex = 6;
            this.findFolder.Text = "Tìm thư mục";
            this.findFolder.UseVisualStyleBackColor = true;
            this.findFolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(42, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // SucessList
            // 
            this.SucessList.FormattingEnabled = true;
            this.SucessList.Location = new System.Drawing.Point(310, 98);
            this.SucessList.Name = "SucessList";
            this.SucessList.Size = new System.Drawing.Size(527, 95);
            this.SucessList.TabIndex = 12;
            // 
            // ErrorList
            // 
            this.ErrorList.FormattingEnabled = true;
            this.ErrorList.Location = new System.Drawing.Point(310, 214);
            this.ErrorList.Name = "ErrorList";
            this.ErrorList.Size = new System.Drawing.Size(527, 95);
            this.ErrorList.TabIndex = 13;
            this.ErrorList.SelectedIndexChanged += new System.EventHandler(this.ErrorList_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(310, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hoàn thành";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(310, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lỗi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 51);
            this.button2.TabIndex = 16;
            this.button2.Text = "In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 51);
            this.button3.TabIndex = 17;
            this.button3.Text = "Chọn máy in";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ErrorList);
            this.Controls.Add(this.SucessList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.findFolder);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.Button findFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox SucessList;
        private System.Windows.Forms.ListBox ErrorList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

