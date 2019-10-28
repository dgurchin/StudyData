using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject.TestMain
{
    public sealed class cThis
    {

        public int i = 10;


        public void Add(int i)
        {
            i += i;

            MessageBox.Show(this.i.ToString());
        }
    }
}
