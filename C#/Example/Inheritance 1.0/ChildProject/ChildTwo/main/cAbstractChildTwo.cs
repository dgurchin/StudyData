using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kernel;

namespace ChildTwo
{
    public class cAbstractChildTwo:cAbstractMother
    {
        public override string ChildName()
        {
            return "Я абстракный ребенок Two";
        }
    }
}
