using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
           txtNhapten.Focus();
        }
        private void ChangeFontStyle()
        {
            FontStyle style = FontStyle.Regular;

            if (checkBox1.Checked) style |= FontStyle.Bold;
            if (checkBox2.Checked) style |= FontStyle.Italic;
            if (checkBox3.Checked) style |= FontStyle.Underline;

            lblLapTrinh.Font = new Font(lblLapTrinh.Font, style);
            txtNhapten.Font = new Font(txtNhapten.Font, style);
        }
        private void changeTextColor(Color color)
        {
            lblLapTrinh.ForeColor = color;
            txtLaptrinh.ForeColor = color;
        }
        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
                changeTextColor(Color.Red);
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked) changeTextColor(Color.Green);
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked) changeTextColor(Color.Blue);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) changeTextColor(Color.Black);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapten.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }
    }
}
