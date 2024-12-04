using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1_mau_
{
    public partial class FrmBai1_1 : Form
    {
        public FrmBai1_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtUser.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += this.txtUser.Text;
            if (this.chkNho.Checked == true)
                thongbao += "\n\r Bạn có ghi Nhớ";
            MessageBox.Show(thongbao, "Thông Báo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtUser.ResetText(); this.txtPass.ResetText(); this.txtUser.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
