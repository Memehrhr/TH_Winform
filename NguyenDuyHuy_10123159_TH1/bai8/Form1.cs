using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGiai.Enabled = false;
            btnXoa.Enabled = false;

            // Gán sự kiện TextChanged cho txtA và txtB
          
        }
        private void tinhToan()
        {
            bool isValid = true;
            if(!double.TryParse(txtA.Text.Trim(), out _) )
            {
                errorProvider1.SetError(txtA, "Hệ số phải là số");
                isValid=false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if(!double.TryParse(txtB.Text.Trim(),out _) )
            {
                errorProvider1.SetError(txtB, "Hệ số B phải là số");
                isValid=false;
            }
            else { errorProvider1.Clear(); }
            btnGiai.Enabled=isValid;
            btnXoa.Enabled=isValid;
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            int a=int.Parse(txtA.Text);
            int b=int.Parse(txtB.Text);
            string result;
            if(a==0)
            {
                result = b == 0?"phương trình vô số nghiệm":"phương trình vô nghiệm";
            }
            else
            {
                double x = -b / a;
                result = $"phương trình có nghiệm: x ={x:F2}";
            }
            txtNo.Text=result;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtNo.Clear();
            txtA.Focus();
            btnGiai.Enabled= false;
            btnXoa.Enabled= false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không","Xác nhận thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                this.Close();
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            tinhToan();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            tinhToan();
        }
    }
}
