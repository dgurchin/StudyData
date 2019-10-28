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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="10")
            {
                MessageBox.Show("URA!!!");
            }
            else
            {
                MessageBox.Show("NO URA!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "10")
            {
                MessageBox.Show("URA!!!");
            }
            else
            {
                MessageBox.Show("NO URA!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            
            if (i <=10)
            {
                MessageBox.Show("URA!!!");
            }
            else
            {
                MessageBox.Show("NO URA!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);

            if (i >= 10)
            {
                MessageBox.Show("URA!!!");
            }
            else
            {
                MessageBox.Show("NO URA!!!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="10" && textBox2.Text=="11")
            {
                MessageBox.Show("URA");
            }
            else
            {
                MessageBox.Show("NO URA!!!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "10"|| textBox2.Text == "11")
            {
                MessageBox.Show("URA");
            }
            else
            {
                MessageBox.Show("NO URA!!!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "10") MessageBox.Show(textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "10")
            {
                for (int i = 10; i < 100; i*=10)
                {
                    MessageBox.Show(i.ToString());
                }

                MessageBox.Show(textBox1.Text);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="10")
            {
                MessageBox.Show("URA");
            }
            else if (textBox2.Text == "11")
            {
                MessageBox.Show("POL URA");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "10")
            {
                MessageBox.Show("URA");
            }
            else if (textBox2.Text == "11")
            {
                MessageBox.Show("POL URA");
            }
            else
            {
                MessageBox.Show("NO URA!!!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var dialogResult = textBox1.Text == "10" ? MessageBox.Show("URA") : MessageBox.Show("NO URA!!");
        }
    }
}
