using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate.JavaCallBack
{
    public class cCallBack:cSimpleClass.Callback
    {
        public void callingBack(string s)
        {
            if (s != null)
            {
                MessageBox.Show("Ваш ответ: " + s);
            }
            else
            {
                MessageBox.Show("Вы не ответили на вопрос!");
            }
        }
    }
}
