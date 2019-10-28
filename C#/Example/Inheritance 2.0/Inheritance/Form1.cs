using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inheritance.NewFolder1;



namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void btnClassic_Click(object sender, EventArgs e)
        {

            cChild a = new cChild();

            a.uName();

            a.vName();

            
        }

        private void btnAbstract_Click(object sender, EventArgs e)
        {
            cAbstractChild a = new cAbstractChild();

            a.aName();

            a.vName();

            a.uName();
        }

        private void btnInerface_Click(object sender, EventArgs e)
        {
            cInterfaceClass a=new cInterfaceClass();

            a.Name();

           
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new cTemplate<Int16>().Min("dsdsd", "dsdsds").ToString());
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Int32 a = 101+10;




            MyClass a1 = 11; //, b = a1+11;

            //MyClass a1=new MyClass(11);





        }

        public class MyClass
        {

            public static implicit operator MyClass(int a)
            {
                if (a<100)
                {
                    MessageBox.Show("");

                    return null;
                }
                else
                {
                    return new MyClass(a);
                }


            }

            private int a;

            public MyClass(int a)
            {

                this.a = a;


            }

            public static MyClass operator +(MyClass a, MyClass b)
            {
                MessageBox.Show((a.a + b.a).ToString());
                
                return b;
            }
        }

       
    }
}
