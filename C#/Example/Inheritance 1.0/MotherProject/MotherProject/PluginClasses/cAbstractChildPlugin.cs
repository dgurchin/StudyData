using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kernel;

namespace MotherProject
{
    public sealed class cAbstractChildPlugin
    {
        private static List<string> abstractChidNames = new List<string>();

        public static ReadOnlyCollection <string> AbstractChidNames
        {
            get { return abstractChidNames.AsReadOnly(); }
        }

        public static void AbstractChild()
        {

            abstractChidNames.Clear();
           


            
            string rootPathToPluginsFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\plugins";
            try
            {


                DirectoryInfo d = new DirectoryInfo(rootPathToPluginsFolder);//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles("*.dll"); //Getting Text files
               
                foreach (FileInfo file in Files)
                {
                    Assembly plugin = Assembly.LoadFrom(file.FullName);
                    var type = plugin.GetExportedTypes();
                    foreach (Type t in type)
                    {
                        // Если мы имеем дело не с поддерживаемым класом - отправляемся вальсировать дальше
                        if (!t.IsClass)
                            continue;

                        // Если мы имеем дело с плагином отхода - грузим его
                        if (typeof(cAbstractMother).IsAssignableFrom(t))
                        {
                            cAbstractMother currentPlugin = (cAbstractMother)Activator.CreateInstance(t);
                            abstractChidNames.Add(currentPlugin.ChildName());
                            
                            
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }


        }
    }
}
