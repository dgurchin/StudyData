using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectConstructor
{
    public class cStaticClass //Адрес
    {


        public cStaticClass()
        {
            MessageBox.Show("KY KY");
        }




        public int Sum(int a, int b)
        {


            
            return a + b;

        }


        public static int Sum_Static(int a, int b)
        {



            return a + b;

        }



    }
}
