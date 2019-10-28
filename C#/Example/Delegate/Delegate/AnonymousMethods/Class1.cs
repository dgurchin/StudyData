using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.AnonymousMethods
{
    class Class1
    {
       

        public void Messa()
        {
             Func<string, int> func;

            func = str;

            func("");
        }

        public int str(string s)
        {
            return s.Length;
        }
    }
}
