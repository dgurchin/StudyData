using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public sealed class cActionTwo
    {
        public void Act(string s)
        {
            MessageBox.Show(s.ToUpper());

            Debug.WriteLine(s);
        }
    }
}
