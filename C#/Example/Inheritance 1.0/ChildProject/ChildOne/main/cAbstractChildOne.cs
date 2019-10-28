using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kernel;

namespace ChildOne
{
    public class cAbstractChildOne : cAbstractMother
    {
        public override string ChildName()
        {
            return "Я абстракный ребенок One";
        }

        public override string vChildName()
        {
            return "Я перегруженный ребенок One";
        }

        
    }
}
