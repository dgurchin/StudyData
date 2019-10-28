using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class TopLevelForm : Form
    {

        string fileName;

        public TopLevelForm()
        {
            InitializeComponent();

            var topLevelForm = this;
            cApp.Application.AddTopLevelForm(ref topLevelForm);

            cApp.Application.AddWindowMenu(windowToolStripMenuItem);
        }

        public static TopLevelForm CreateTopLevelWindow(string fileName)
        {
            // Detect whether file is already open
            if (!string.IsNullOrEmpty(fileName))
            {
                foreach (TopLevelForm openForm in Application.OpenForms)
                {
                    if (string.Compare(openForm.FileName(), fileName, true) == 0)
                    {
                        // Bring form to top
                        openForm.Activate();
                        return openForm;
                    }
                }
            }

            // Create new top-level form and open file
            TopLevelForm form = new TopLevelForm();
            form.OpenFile(fileName);
            form.Show();
            // Bring form to top
            form.Activate();
            return form;
        }

        void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open new window
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CreateTopLevelWindow(openFileDialog.FileName);
            }
        }

        public void OpenFile(string fileName)
        {
            this.fileName = fileName;

            if (string.IsNullOrEmpty(fileName)) return;
            
            using (StreamReader reader = new StreamReader(fileName))
            {
                textBox.Text = reader.ReadToEnd();
            }

            Text = Text + " (" + this.fileName + ")";
        }

        public string FileName()
        {
            return fileName; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new string[1])[0] = string.Empty;

            var topLevelForm = new TopLevelForm();
            cApp.Application.AddTopLevelForm(ref topLevelForm);
        }

        
    }
}
