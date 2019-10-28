using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_DB.Class_for_DB;
using Test_DB.DB;

namespace Test_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = Application.StartupPath + @"\New_DB.db";

            var oConnect_DB=new cConnect();

            
            oConnect_DB.Init(s);

            //oConnect_DB.Create_DB();

            foreach (var VARIABLE in tFirstTable.FindAll())
            {
                MessageBox.Show(VARIABLE.ID_FirstTable + " " + VARIABLE.ModelProperty2);
            }
            
        }
    }
}
