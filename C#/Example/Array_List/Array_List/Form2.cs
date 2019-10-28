using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_List
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 [] a=new Form2[10];

            for (int i = 0; i < a.Count(); i++)
            {
                a[i] = new Form2();
            }

            for (int i = 0; i < a.Count(); i++)
            {
                a[i].Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Form2> f=new List<Form2>();

            
            for (int i = 0; i < 10; i++)
            {
                f.Add(new Form2());
            }

            foreach (var VARIABLE in f)
            {
                VARIABLE.Show();
             
   
            }
        }

        
    }
}
