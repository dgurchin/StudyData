using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel
{
    public abstract class cAbstractMother
    {
        public abstract string ChildName();

        public virtual string vChildName()
        {
           return "Хуй вам а не ребенок";
        }

        public string fChildName()
        {
            return "Я блять Ваша мать! Или ГДЕ!!!!";
        }
    }
}
