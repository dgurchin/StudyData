using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject.TestMain
{
    public sealed class cRef
    {
        //private int z = 10;
       


        public  void Ref(ref int i)
        {
            i += 10;

            MessageBox.Show(i.ToString());
        }


        public void WithOutRef(int i)
        {

            i += 10;

            MessageBox.Show(i.ToString());
        }
    }
}
