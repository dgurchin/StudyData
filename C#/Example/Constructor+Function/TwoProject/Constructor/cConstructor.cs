using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoProject.Constructor
{
    public class cConstructor
    {
        //но если нет ни одного конструктора, то компилятор сам создает конструктор по умолчанию.

        //но если есть хотя бы один конструктор, компилятор не создает конструктор по умолчанию. Его приходится создавать самому

        public cConstructor() //пустой конструктор или конструктор по умолчанию.
        {

        }

        

        public cConstructor(int i) // конструктор с аргументной частью
        {
            
        }

        public void messa()
        {
        }


        public static implicit operator cConstructor(int i)
        {
            return new cConstructor(i);
        }











































    }
}
