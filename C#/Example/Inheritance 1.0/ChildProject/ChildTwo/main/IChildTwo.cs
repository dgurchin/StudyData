using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kernel;

namespace ChildTwo
{
    class IChildTwo:IMother
    {
        public string NameChild()
        {
            return "Я ребенок интерфейса Two";
        }

        
    }
}
