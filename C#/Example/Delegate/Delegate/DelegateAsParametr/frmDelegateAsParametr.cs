using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate.DelegateAsParametr
{
    
    public partial class frmDelegateAsParametr : Form
    {

        delegate int dAction(int x, int y);

        

        public frmDelegateAsParametr()
        {
            InitializeComponent();
        }

        private void btnOneAction_Click(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(textBox1.Text);
            int y=Convert.ToInt32(textBox2.Text);

            if (rdbMultiply.Checked)
            {
                DoOperation(x, y, Multiply);
            }
            else if (rdbDevide.Checked)
            {
               DoOperation(x, y, Divide);
            }
            else
            {
                MessageBox.Show("Not Change");
            }

        }


        void DoOperation(int x, int y, dAction del)
        {
            int z = del(x, y);
            MessageBox.Show(z.ToString());
        }

        int Multiply(int x, int y)
        {
            return x * y;
        }

        int Divide(int x, int y)
        {
            return x / y;
        }
       
    }
}
