using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class MulticastDelegate : Form
    {

        private delegate void Multicast_Delegate(string s);

        public MulticastDelegate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cActionOne a=new cActionOne();

            a.Act(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cActionTwo a = new cActionTwo();

            a.Act(textBox1.Text);
        }

        private void btnMulticastDelegate_Click(object sender, EventArgs e)
        {

            
            
            
            //Событие 1
            cActionOne One = new cActionOne();

            One.Act(textBox1.Text);


            //Событие 2
            cActionTwo Two = new cActionTwo();

            Two.Act(textBox1.Text);
            
            
            Multicast_Delegate dDelegate = new cActionOne().Act;

            dDelegate += new cActionTwo().Act;

            dDelegate("Снеговик");



        }

        private void MulticastDelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
