using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] f=new int[10];

            for (int i = 0; i<f.Count()+1; i++)
            {
                Debug.WriteLine(i);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> list=new List<int>();

            list.Add(1);
            list.Add(2);

            int z = 0;

            while (z < 100)
            {
                list.Add(z);
                z++;
            }


            for (int i = 0; i < list.Count; i++)
            {
                Debug.WriteLine(list[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] f = new int[10,10];

            for (int i = 0; i < f.GetLength(0); i++)
            {
                Debug.Write(i+"\t");

                for (int j = 0; j < f.GetLength(1); j++)
                {
                    Debug.Write(j + "\t");
                }
                Debug.Write("\n");
            }
           



        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> aInts =new List<int>();

            List<List<int>> nList=new List<List<int>>();

            for (int i = 0; i < 10; i++)
            {
                aInts.Add(i);
            }

            for (int i = 0; i <10; i++)
            {
                nList.Add(aInts);
            }


            for (int i = 0; i < nList.Count; i++)
            {
                Debug.Write(aInts[i]+"\t");
                foreach (var VAR in nList[i])
                {
                    Debug.Write(VAR+"\t");
                }

                Debug.Write("\n");
            }
            
            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
