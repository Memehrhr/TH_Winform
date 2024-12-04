using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtSo.Focus(); // Đưa con trỏ vào TextBox khi form được tải
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSo.Text, out int result))
            {
                cboSo.Items.Add(result); // Thêm vào ComboBox nếu hợp lệ
                txtSo.Clear(); // Xóa nội dung TextBox
                txtSo.Focus(); // Đặt con trỏ vào TextBox
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.Focus(); // Đưa con trỏ lại TextBox
                txtSo.SelectAll(); // Chọn toàn bộ nội dung để nhập lại dễ dàng
            }
        }


        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(int.TryParse(cboSo.SelectedItem?.ToString(), out int selectedNumber))
            {
                listBox1.Items.Clear();
                List<int> uocSo = TinhUocSo(selectedNumber);
                foreach (int uoc in uocSo)
                {
                    listBox1.Items.Add(uoc);
                }
            }
        }
        private List<int> TinhUocSo(int NumBer)
        {
            List<int> uocSO= new List<int>();
            for(int i = 1;i<NumBer;i++)
            {
                if(NumBer%i==0)
                    uocSO.Add(i);
            }
            return uocSO;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                int Tong=listBox1.Items.Cast<int>().Sum();
            
            MessageBox.Show($"Tổng các ước số {Tong}","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dem = 0;
            int SsoChan = listBox1.Items.Cast<int>().Count();
            if(SsoChan%2==0)
            {
                dem++;
            }
            MessageBox.Show($"Số lượng số chắn là :{dem}","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int soLuongNguyenTo = listBox1.Items.Cast<int>().Count(IsPrime);
            MessageBox.Show($"Số lượng các ước số nguyên tố: {soLuongNguyenTo}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}

