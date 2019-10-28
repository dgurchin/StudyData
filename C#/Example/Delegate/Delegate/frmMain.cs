using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delegate.AnonymousMethods;
using Delegate.DelegateAsParametr;
using Delegate.Event;
using Delegate.JavaCallBack;

namespace Delegate
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMulticastDelegate_Click(object sender, EventArgs e)
        {
            new MulticastDelegate().ShowDialog();

        }

        private void btnAnonymousMethods_Click(object sender, EventArgs e)
        {
            new frmAnonymousMethods().ShowDialog();
        }
        
        private void btnDelegateAsParametr_Click(object sender, EventArgs e)
        {
            new frmDelegateAsParametr().ShowDialog();
        }

        

        private void btnEvents_Click(object sender, EventArgs e)
        {
            new frmEvents().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmJavaCallBack().ShowDialog();
        }
    }
}
