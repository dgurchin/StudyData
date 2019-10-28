using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_with_CPP
{
   
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnC_PP_Click(object sender, EventArgs e)
        {
            MessageBox.Show(funcCPP(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString());

            f("Pribet Привет");
        }

        [DllImport("CPP_Lib.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int funcCPP(int a, int b);

        [DllImport("CPP_Lib.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void f(string s);

    }


    public static class cNative
    {
        


    }
}
