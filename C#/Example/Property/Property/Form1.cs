using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Property
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cProperty aCProperty=new cProperty();

            aCProperty.STR = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cProperty aCProperty = new cProperty();

            textBox1.Text = aCProperty.STR;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            cProperty aCProperty = new cProperty();

            textBox2.Text=aCProperty.getValue();

            textBox2.Text = 10.ToString();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            cProperty aCProperty = new cProperty();

            aCProperty.setValue(textBox2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cProperty aCProperty=new cProperty();

            aCProperty.ddd = "Dima Privet";

            MessageBox.Show(aCProperty.ddd);
        }

        

       
    }
}
