using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            cProperty t=new cProperty();

            t.Name = textBox1.Text;

            t.SurName = textBox2.Text;

            t.LastName = textBox3.Text;

            //foreach (var VARIABLE in COLLECTION)
            //{
            //    t.replace(VARIABLE.)
            //}
            string a = "{Name}  Этот челове НЕ ХУЙ {SurName}" + "{Name}" + "  " + " {LastName} "; //html row
            MessageBox.Show(t.replace(a));
            //t.Name = "GGGGGG";
            //MessageBox.Show(t.replace(a));

        }


      
        
    }
}
