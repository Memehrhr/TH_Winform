using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Focus();
        }

        private void radTime_CheckedChanged(object sender, EventArgs e)
        {
            if (radTime.Checked)
            {
                txt1.Font = new Font("Time New Roman", txt1.Font.Size);
            }
        }

        private void radArial_CheckedChanged(object sender, EventArgs e)
        {
            if (radArial.Checked) txt1.Font = new Font("Arial", txt1.Font.Size);
        }

        private void radTahoma_CheckedChanged(object sender, EventArgs e)
        {
            if(radTahoma.Checked) txt1.Font=new Font("Tahoma",txt1.Font.Size);
        }

        private void radCourier_CheckedChanged(object sender, EventArgs e)
        {
            if(radCourier.Checked) txt1.Font=new Font("Courier New",txt1.Font.Size);
        }
    }
}
