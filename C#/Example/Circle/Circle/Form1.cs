using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 10; y ++)
            {
                MessageBox.Show(y.ToString());
            }

            int x = 10;

            //Бессконечный цикл
            for (; ; )
            {

                x++;
                if (x==100) continue;
                
                Debug.WriteLine(x);

                if(x==200) break;
            }

            int t = 0;
           

            int z = 10;

            z += 10;
            z += 10;

            z++;

            MessageBox.Show(z.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i != 100)
            {
                i++;
                Debug.WriteLine(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int i = 0;

            do
            {
                i++;
                Debug.WriteLine(i);

            } while (i<100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Button> a=new List<Button>();

            for (int i = 1; i < 101; i++)
            {
                Button y=new Button();

                y.Text = i.ToString();
                
                a.Add(y);
            }


            foreach (var VARIABLE in a)
            {
                if (VARIABLE.Text==50.ToString()) continue;

                Debug.WriteLine(VARIABLE.Text);
            }
        }
    }
}
