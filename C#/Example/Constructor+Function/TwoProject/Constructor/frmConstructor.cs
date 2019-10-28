using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoProject.Constructor
{
    public partial class frmConstructor : Form
    {
        public frmConstructor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cConstructor aCConstructor=new cConstructor(10); //идентичный вызов
            

            
            cConstructor c = 10;                            //идетичный вызов


            c.messa();
            int a = 10; //вызов конструктора по сокращенной форме


            
        }
    }
}
