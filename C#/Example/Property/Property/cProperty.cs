using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Property
{
    public class cProperty
    {
        private int a = 5;

       public string ddd {
           get { return a.ToString(); }
           set { }
       }




       

        public string STR
        {
            get
            {
                return a.ToString();
            }

            set
            {
                int distance;
                if (int.TryParse(Program.oForm1.textBox1.Text, out distance))
                {
                    Program.oForm1.textBox1.Text = Convert.ToString(distance + a);
                }
                else
                {
                    STR= "Error";
                }

                
            }

        }

        public void setValue(TextBox txt)
        {
            int distance;
            if (int.TryParse(txt.Text, out distance))
            {
               txt.Text = Convert.ToString(distance + a);
            }
            else
            {
                txt.Text = "Error";
            }
           
        }

        public string getValue()
        {
            return STR;

        }
       

    }
}