using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Load();
        }

        private void Load()
        {
            List<RadioButton> radioBtns = new List<RadioButton>() { 
                VietNambtn,
                USAbtn,
                Italiabtn,
                Philippinesbtn,
            };

            foreach(RadioButton btn in radioBtns)
            {
                btn.Click += (sender, e) =>
                {
                    FlagPtb.Image = Image.FromFile(Application.StartupPath + "\\" + btn.Text + ".jpg");
                };
            }
        }
    }
}
