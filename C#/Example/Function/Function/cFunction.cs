using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function
{
    public class cFunction
    {
        private string s;

        public string S
        {
            get { return s; }
            set { s = value; }
        }

        private List<int> Table = new List<int>();

        private int result(string s)
        {
            return s.Length;
        }


        public void Add(string s)
        {
            Table.Add(result(s));
        }


        

        public void Result()
        {

            string s = null;

            foreach (int VARIABLE in Table)
            {
                s += VARIABLE + "\n";
            }

            MessageBox.Show(s);

        }


        public void Clear()
        {
            Table.Clear();
        }

    }
}
