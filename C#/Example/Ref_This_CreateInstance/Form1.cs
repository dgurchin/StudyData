using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.Properties;
using TestProject.TestMain;

namespace TestProject
{
    public partial class Form1 : Form
    {









        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //this.Text

            var a = (cCreateInstance) Activator.CreateInstance(typeof (cCreateInstance), this, "Hay");

            
            //cCreateInstance b=Activator.CreateInstance(typeof(cCreateInstance),)


            //Params(1,2,3,4,5);

            //Params(0);


        }

        private void Params(params int [] a)
        {
            StringBuilder s=new StringBuilder();

            foreach (var VARIABLE in a)
            {
                s.AppendLine(VARIABLE.ToString());
            }


            MessageBox.Show(s.ToString());
        }

        int z = 20;

        private void button2_Click(object sender, EventArgs e)
        {

            

            new cRef().Ref(ref z);

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            new cRef().WithOutRef(z);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var b = this;
            new Form2(b).ShowDialog();
        }




    }
}
