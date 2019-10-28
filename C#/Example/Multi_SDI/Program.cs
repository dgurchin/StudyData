using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        
       
        
        
        public static Mutex mutex = null;
        
        [STAThread]
        static void Main(string[] args)
        {

        
           

            //const string appName = "MyAppName";
            //bool createdNew;


          

           

            //mutex = new Mutex(true, appName, out createdNew); 


            //new cP();

            //Process[] processes = Process.GetProcesses();

            //Process me = Process.GetCurrentProcess();
            //foreach (Process p in processes)
            //{
            //    if (p.ProcessName == me.ProcessName)
            //    {
            //        return;


            //    }
            //}

            //if (!createdNew)
            //{

            //    //Process p = new Process();
            //    //p.StartInfo.FileName =
            //    //    System.Reflection.Assembly.GetExecutingAssembly().Location;
            //    //p.Start();

               

            //}
            //else
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);



            


            


            cApp.Application.Run(args);

            //    Application.Run();
            //}  




            

           


            



            //MessageBox.Show("111");


        }
    }
}
