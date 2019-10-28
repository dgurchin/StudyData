using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Kernel
{

    public delegate void ChildHandler();



    public abstract class cAbstractClass
    {

        public abstract string Name();

        public event ChildHandler Child;

        public void DoEvent()
        {
            if (Child!=null)
            {
                Child();
            }
        }

    }
}
