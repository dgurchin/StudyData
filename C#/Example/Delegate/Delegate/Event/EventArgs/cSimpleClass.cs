using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Event.EventArgs
{
    public sealed class cSimpleClass
    {

        public event EventHandler PropChange;

        private string s;

        public string S
        {
            get { return s; }
            set
            {
                s = value;

                PropChange(this, new System.EventArgs());
            }
        }
    }
}
