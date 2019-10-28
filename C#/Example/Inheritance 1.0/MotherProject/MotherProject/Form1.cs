using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotherProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnAbstractMother_Click(object sender, EventArgs e)
        {
            cAbstractChildPlugin.AbstractChild();

            foreach (var VARIABLE in cAbstractChildPlugin.AbstractChidNames)
            {
                listBox1.Items.Add(VARIABLE);
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
