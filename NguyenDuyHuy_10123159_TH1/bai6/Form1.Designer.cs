namespace bai6
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radTime = new System.Windows.Forms.RadioButton();
            this.radArial = new System.Windows.Forms.RadioButton();
            this.radTahoma = new System.Windows.Forms.RadioButton();
            this.radCourier = new System.Windows.Forms.RadioButton();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(44, 49);
            this.txt1.Margin = new System.Windows.Forms.Padding(5);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(122, 143);
            this.txt1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập văn bản";
            // 
            // radTime
            // 
            this.radTime.AutoSize = true;
            this.radTime.Location = new System.Drawing.Point(212, 61);
            this.radTime.Name = "radTime";
            this.radTime.Size = new System.Drawing.Size(107, 17);
            this.radTime.TabIndex = 3;
            this.radTime.TabStop = true;
            this.radTime.Text = "Time NewRoman";
            this.radTime.UseVisualStyleBackColor = true;
            this.radTime.CheckedChanged += new System.EventHandler(this.radTime_CheckedChanged);
            // 
            // radArial
            // 
            this.radArial.AutoSize = true;
            this.radArial.Location = new System.Drawing.Point(212, 100);
            this.radArial.Name = "radArial";
            this.radArial.Size = new System.Drawing.Size(43, 17);
            this.radArial.TabIndex = 4;
            this.radArial.TabStop = true;
            this.radArial.Text = "Aral";
            this.radArial.UseVisualStyleBackColor = true;
            this.radArial.CheckedChanged += new System.EventHandler(this.radArial_CheckedChanged);
            // 
            // radTahoma
            // 
            this.radTahoma.AutoSize = true;
            this.radTahoma.Location = new System.Drawing.Point(212, 141);
            this.radTahoma.Name = "radTahoma";
            this.radTahoma.Size = new System.Drawing.Size(64, 17);
            this.radTahoma.TabIndex = 5;
            this.radTahoma.TabStop = true;
            this.radTahoma.Text = "Tahoma";
            this.radTahoma.UseVisualStyleBackColor = true;
            this.radTahoma.CheckedChanged += new System.EventHandler(this.radTahoma_CheckedChanged);
            // 
            // radCourier
            // 
            this.radCourier.AutoSize = true;
            this.radCourier.Location = new System.Drawing.Point(212, 175);
            this.radCourier.Name = "radCourier";
            this.radCourier.Size = new System.Drawing.Size(83, 17);
            this.radCourier.TabIndex = 6;
            this.radCourier.TabStop = true;
            this.radCourier.Text = "Courier New";
            this.radCourier.UseVisualStyleBackColor = true;
            this.radCourier.CheckedChanged += new System.EventHandler(this.radCourier_CheckedChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(107, 206);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 261);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.radCourier);
            this.Controls.Add(this.radTahoma);
            this.Controls.Add(this.radArial);
            this.Controls.Add(this.radTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radTime;
        private System.Windows.Forms.RadioButton radArial;
        private System.Windows.Forms.RadioButton radTahoma;
        private System.Windows.Forms.RadioButton radCourier;
        private System.Windows.Forms.Button btnthoat;
    }
}

