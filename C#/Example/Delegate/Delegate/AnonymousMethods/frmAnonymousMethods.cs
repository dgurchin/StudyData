using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate.AnonymousMethods
{

    
    public partial class frmAnonymousMethods : Form
    {

        private delegate void dDelegate(int i);
         
        
        
        
        
        public frmAnonymousMethods()
        {
            InitializeComponent();
        }

        private void btnAnonymousMethods_Click(object sender, EventArgs e)
        {

            string s = "Anonymous methods";
            

            
            dDelegate d = delegate(int k)
            {
                s = "Anonymous methods UHUUU!!!!!";

                MessageBox.Show(s+k);
                
               
            };



            d += Mes;
           
            MessageBox.Show("Normal Instruction");

            d(12);

            d(10);
        }

        private void Mes(int i)
        {
            
            MessageBox.Show("NOOOOOO!!!!! Anonymous methods + "+ i);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
