﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function
{
    public partial class frmFunction : Form
    {

        cFunction Function = new cFunction();


        public frmFunction()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Function.Add(txtString.Text);
            txtString.Clear();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Function.Result();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Function.Clear();
        }
    }
}
