using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate.JavaCallBack
{
    public partial class frmJavaCallBack : Form
    {
        public frmJavaCallBack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cSimpleClass someClass = new cSimpleClass();
            cCallBack myClass = new cCallBack();

            //инициализируем колбек, передавая методу registerCallBack экземпляр MyClass, реализующий интерфейс колбек

            someClass.doSomething(myClass);


        }
    }
}
