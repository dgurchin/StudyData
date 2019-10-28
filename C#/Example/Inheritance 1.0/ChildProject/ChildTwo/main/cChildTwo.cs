using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kernel;

namespace ChildTwo
{
    public class cChildTwo:cMother
    {
        public override string ChildName()
        {
            return "Я обычный ребенок Two";
        }
    }
}
