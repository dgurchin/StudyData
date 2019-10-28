using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace WindowsFormsApplication2
{
    public class cApp : WindowsFormsApplicationBase
    {
        public static cApp Application;


        static cApp ()
        {
            Application = new cApp();

         
        }

        protected override void OnRun()
        {

            MessageBox.Show("---------");

            base.OnRun();
        }

        public cApp()
        {

            this.EnableVisualStyles = true;

            // This ensures the underlying single-SDI framework is employed,
            // and OnStartupNextInstance is fired
            this.IsSingleInstance = true;
            // Needed for multiple SDI because no form is the main form
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;





        }

        public void AddTopLevelForm(ref TopLevelForm form)
        {


            // Add form to collection of forms and
            // watch for it to activate and close
            
            // Set initial top-level form to activate
            if (this.OpenForms.Count == 1) this.MainForm = form;

            form.Show();
        }

        void Form_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("---");
           
            MainForm = (Form)sender;
        }

        

        void Form_FormClosed(object sender, FormClosedEventArgs e) 
        {
            // Set a new "main" if necessary
            Form form = (Form) sender;
            
            if( (form == this.MainForm) && (OpenForms.Count > 0) )
            {
                MainForm = OpenForms[0];
            }


            form.Activated -= Form_Activated;
            form.FormClosed -= Form_FormClosed;
        }


        protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
        {

            MessageBox.Show("+++");

            return base.OnInitialize(commandLineArgs);

            
        }

        protected override void OnCreateMainForm()
        {

            MessageBox.Show("111111");

            MainForm = CreateTopLevelWindow(CommandLineArgs);
        }

        TopLevelForm CreateTopLevelWindow(ReadOnlyCollection<string> args)
        {
            // Get file name, if provided
            string fileName = (args.Count > 0 ? args[0] : null);
            // Create a new top-level form
            return TopLevelForm.CreateTopLevelWindow(fileName);
        }


        

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs e)
        {
           

            this.CreateTopLevelWindow(e.CommandLine);
        }

        public void windowMenu_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem) sender;


            // Clear current menu
            if (menu.DropDownItems.Count > 0)
            {
                menu.DropDown.Dispose();
            }

            menu.DropDown = new ToolStripDropDown();

            // Populate menu with one item for each open top-level form
            foreach (Form form in this.OpenForms)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = form.Text;
                item.Tag = form;
                menu.DropDownItems.Add(item);
                item.Click += WindowMenuItem_Click;

                // Check menu item that represents currently active window
                if (form == this.MainForm) item.Checked = true;
            }
        }

        void WindowMenuItem_Click(object sender, EventArgs e)
        {
            // Activate top-level form based on selection
            ((Form)((ToolStripMenuItem)sender).Tag).Activate();
        }

        public void AddWindowMenu(ToolStripMenuItem windowMenu)
        {
            // Handle tool strip menu item's drop-down opening event
            windowMenu.DropDownOpening +=    windowMenu_DropDownOpening;
        }

    }

}
