using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class BaiTap01 : Form
    {
        public BaiTap01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string text = txtN.Text;
            int n = int.Parse(text);
            string text1 = txtTong.Text;
            int n1 = int.Parse(text1);
            int s = n + n1;
           
            btketqua.Text=s.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
