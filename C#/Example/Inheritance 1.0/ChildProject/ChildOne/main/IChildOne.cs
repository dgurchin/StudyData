using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kernel;


namespace ChildOne
{
    public class IChildOne : IMother
    {
        public string NameChild()
        {
            return "Я ребенок интерфейса One";
        }
    }
}
