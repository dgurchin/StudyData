using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kernel;

namespace ChildThree
{
    public class cAbstractChildThree:cAbstractMother
    {
        public override string ChildName()
        {
            return "Я абстракный ребенок Three";
        }
    }
}
