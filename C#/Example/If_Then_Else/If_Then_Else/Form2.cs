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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == true) && (textBox1.Text == "10" || textBox2.Text == "12"))
            {
                
                MessageBox.Show("URA");
            }
            else
            {
                MessageBox.Show("NO URA!!!");
            }
            

        }
    }
}
