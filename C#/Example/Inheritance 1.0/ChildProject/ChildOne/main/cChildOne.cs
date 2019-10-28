using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kernel;

namespace ChildOne
{
    public class cChildOne:cMother
    {
        public override string ChildName()
        {
            return "Я обычный ребенок One";
        }
    }
}
