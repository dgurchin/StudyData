using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotherProject
{
    //public sealed class cIChildName
    //{
    //    private static List<string> IChildName = new List<string>();

    //    public static List<string> I_ChildName
    //    {
    //        get { return IChildName; }
    //    }
    //    public static void InterfaceChild()
    //    {

    //        wastesNames.Clear();
    //        wastesTypesId.Clear();
    //        wasteTypes.Clear();
    //        wastesImage.Clear();


    //        string tmpPluginName = "";
    //        string rootPathToPluginsFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\plugins";
    //        try
    //        {

    //            // Скан папки плагинов отходов
    //            string pathToPluginsFolder = rootPathToPluginsFolder + @"\Wastes";
    //            {
    //                DirectoryInfo di = new DirectoryInfo(pathToPluginsFolder);
    //                DirectoryInfo[] pluginFolders = di.GetDirectories();
    //                foreach (DirectoryInfo currentDir in pluginFolders)
    //                {

    //                    //цикл по подпапкам в папке плагинов
    //                    Assembly plugin = Assembly.LoadFrom(pathToPluginsFolder + @"\" + currentDir.Name + @"\" + currentDir.Name + ".dll");
    //                    var type = plugin.GetExportedTypes();
    //                    foreach (Type t in type)
    //                    {
    //                        // Если мы имеем дело не с поддерживаемым класом - отправляемся вальсировать дальше
    //                        if (!t.IsClass)
    //                            continue;

    //                        // Если мы имеем дело с плагином отхода - грузим его
    //                        if (typeof(cBaseWastePlugin).IsAssignableFrom(t))
    //                        {
    //                            cBaseWastePlugin currentPlugin = (cBaseWastePlugin)Activator.CreateInstance(t);
    //                            wastesNames.Add(currentPlugin.GetName());
    //                            wastesTypesId.Add(currentPlugin.GetItemGUID().GetHashCode());  // Старая версия определения типов плагина
    //                            wasteTypes.Add(t);
    //                            wastesImage.Add(currentPlugin.GetitemImage());
    //                            wastesFoldersPaths.Add(currentDir.FullName);
    //                            continue;
    //                        }
    //                    }
    //                }
    //            }

    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message);


    //        }


    //    }
    //}
}
