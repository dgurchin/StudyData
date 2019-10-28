using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate.JavaCallBack
{
    public class cSimpleClass
    {
        private String replyTo;

        
        public  interface Callback
        {
            void callingBack(String s);
        }

        
        public void doSomething(Callback callback)
        {



            DialogResult result = MessageBox.Show("Do you want to save changes?", 
                                    "Confirmation", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                replyTo = DialogResult.Yes.ToString();
            }
            else if (result == DialogResult.No)
            {
                replyTo = DialogResult.No.ToString();
            }



            //Код на Java
            //int reply = JOptionPane.showConfirmDialog(null, "Вы программист?", "Опрос", JOptionPane.YES_NO_OPTION);

            //if (reply == JOptionPane.NO_OPTION)
            //{
            //    replyTo = "Нет";
            //}
            //if (reply == JOptionPane.YES_OPTION)
            //{
            //    replyTo = "Да";
            //}

            
            callback.callingBack(replyTo);
        }
    }
}
