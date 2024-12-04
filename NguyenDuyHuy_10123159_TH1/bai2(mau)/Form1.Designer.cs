namespace bai2_mau_
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
            this.h = new System.Windows.Forms.Button();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.hh = new System.Windows.Forms.Label();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.txtXoa = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(41, 220);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(96, 32);
            this.h.TabIndex = 1;
            this.h.Text = "Kết quả";
            this.h.UseVisualStyleBackColor = true;
            this.h.Click += new System.EventHandler(this.btnKetqua_Click);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(157, 31);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(322, 26);
            this.txtHoten.TabIndex = 2;
            // 
            // hh
            // 
            this.hh.AutoSize = true;
            this.hh.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hh.Location = new System.Drawing.Point(35, 31);
            this.hh.Name = "hh";
            this.hh.Size = new System.Drawing.Size(116, 19);
            this.hh.TabIndex = 0;
            this.hh.Text = "Nhập họ và tên:";
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(14, 53);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(96, 23);
            this.rad1.TabIndex = 4;
            this.rad1.TabStop = true;
            this.rad1.Text = "chữ thường";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(14, 82);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(120, 23);
            this.rad2.TabIndex = 5;
            this.rad2.TabStop = true;
            this.rad2.Text = "CHỮ IN HOA";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // txtXoa
            // 
            this.txtXoa.Location = new System.Drawing.Point(450, 93);
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Size = new System.Drawing.Size(69, 121);
            this.txtXoa.TabIndex = 6;
            this.txtXoa.Text = "Xoá";
            this.txtXoa.UseVisualStyleBackColor = true;
            this.txtXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(157, 220);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(322, 26);
            this.txtKQ.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad2);
            this.groupBox1.Controls.Add(this.rad1);
            this.groupBox1.Location = new System.Drawing.Point(27, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 121);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kiểu chữ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 274);
            this.Controls.Add(this.txtXoa);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.h);
            this.Controls.Add(this.hh);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Đổi kiểu chữ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button h;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label hh;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.Button txtXoa;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

