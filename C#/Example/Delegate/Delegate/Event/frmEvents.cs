using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delegate.AnonymousMethods;
using Delegate.Event.EventArgs;


namespace Delegate.Event
{


    public partial class frmEvents : Form
    {

        public frmEvents()
        {
            InitializeComponent();
        }

        
        private void btnEvent_Click(object sender, System.EventArgs e)
        {
            cStudent student;

            cListSrudents lisStudents = new cListSrudents();

            for (int i = 0; i < 10; i++)
            {
                student = new cStudent();

                lisStudents.Money += student.getMoney;



            }


            lisStudents.DoEvents(100);
        }


        private void button1_Click(object sender, System.EventArgs e)
        {

             cSimpleClass a=new cSimpleClass();

            a.PropChange+=new EventHandler(ms);

            a.S = "Dima";


        }

        private void ms(object sender, System.EventArgs e)
        {
            MessageBox.Show("ProppertyChange");

            frmAnonymousMethods a=new frmAnonymousMethods();

            
        }




    }

    
}
