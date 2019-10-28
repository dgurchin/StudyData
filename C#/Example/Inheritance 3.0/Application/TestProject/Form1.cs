using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Kernel;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private List<cAbstractClass> tmp=new List<cAbstractClass>(); 

        private void Form1_Load(object sender, EventArgs e)
        {




            string tmpPluginName = "";
            string rootPathToPluginsFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\plugins";
            try
            {


                {
                    DirectoryInfo di = new DirectoryInfo(rootPathToPluginsFolder);
                    DirectoryInfo[] pluginFolders = di.GetDirectories();
                    foreach (DirectoryInfo currentDir in pluginFolders)
                    {

                        //цикл по подпапкам в папке плагинов
                        Assembly plugin =
                            Assembly.LoadFrom(rootPathToPluginsFolder + @"\" + currentDir.Name + @"\" + currentDir.Name +
                                              ".dll");
                        var type = plugin.GetExportedTypes();
                        foreach (Type t in type)
                        {
                            // Если мы имеем дело не с поддерживаемым класом - отправляемся вальсировать дальше
                            if (!t.IsClass)
                                continue;

                             //Если мы имеем дело с плагином отхода - грузим его
                            if (typeof(cAbstractClass).IsAssignableFrom(t))
                            {
                                cAbstractClass currentPlugin = (cAbstractClass)Activator.CreateInstance(t);
                                tmp.Add(currentPlugin);

                                lstMain.Items.Add(currentPlugin.Name());
                               
                               
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }


        }

        private void lstMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMain.SelectedIndex>-1)
            {
                tmp[lstMain.SelectedIndex].DoEvent();
            }

        }




    }
}
