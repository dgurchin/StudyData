using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Kernel;

namespace ChildThree
{
    public class cChildThree:cAbstractClass
    {
        public cChildThree()
        {
            Child += emptyFunction;
        }

        private void emptyFunction()
        {
            MessageBox.Show(GetType().ToString());
        }
        public override string Name()
        {
            return "Child Three";
        }
    }
}
