using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.TestMain;

namespace TestProject
{
    public partial class Form2 : Form
    {
        private Form1 a;

        public Form2(Form1 a)
        {
            InitializeComponent();

            this.a = a;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cCreateInstance b = (cCreateInstance)Activator.CreateInstance(typeof(cCreateInstance), a, "Hay");
        }
    }
}
