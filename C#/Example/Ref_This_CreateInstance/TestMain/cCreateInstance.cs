using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject.TestMain
{
    public sealed class cCreateInstance
    {

        public cCreateInstance(Form1 frm, string s)
        {

            frm.Text = s;

            this.a("");

        }

        public void a(string s)
        {
            MessageBox.Show(s);

        }
    }
}
