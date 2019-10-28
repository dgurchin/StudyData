using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_Then_Else
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("ХА хА хА");
                    break;

                case 1:
                    MessageBox.Show("ХО ХО ХО");
                    break;

                case 2:
                    MessageBox.Show("ХИ ХИ ХИ");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("ХА хА хА");
                    break;

                case 1:
                    MessageBox.Show("ХО ХО ХО");
                    break;

                case 2:
                    MessageBox.Show("ХИ ХИ ХИ");
                    break;

                default:
                    MessageBox.Show("А хуюшки вам");
                    break;
            }
        }
    }
}
