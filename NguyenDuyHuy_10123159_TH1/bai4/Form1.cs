using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            TinhToan();
        }
        private void radTru_CheckedChanged(object sender, EventArgs e)
        {
            TinhToan();
        }
        private void radNhan_CheckedChanged(object sender, EventArgs e)
        {
            TinhToan();
        }

        private void radChia_CheckedChanged(object sender, EventArgs e)
        {
            TinhToan();
        }


               
        

      
        private void TinhToan()
        {
            try
            {
            int a1 = int.Parse(txt1.Text);
            int b1 = int.Parse(txt2.Text);
            int ketqua = 0;
            if(radCong.Checked)
            {
                 ketqua= a1 + b1;
            }
            else if (radTru.Checked)
            {
                ketqua = a1 - b1;
            }
            else if (radNhan.Checked)
            {
                ketqua = a1*b1;
            }
            else if (radChia.Checked)
            {
                if(b1!=0)
                {
                    ketqua = a1 / b1;
                }
                else
                {
                    MessageBox.Show("không chia hết được cho 0 ","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                }
            }
            
            txtKQ.Text=ketqua.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
