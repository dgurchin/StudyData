using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Event
{


    public delegate void MessageOfMoney(int i);

    public class Dekan
    {
        public void Stud(int i)
        {

        }
    }

    public sealed class cListSrudents
    {

        public event MessageOfMoney Money;
        


        public void DoEvents(int i)
        {
            if (Money != null) Money(i);
        }


    }
}
