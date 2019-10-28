using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;

namespace Test_DB.Class_for_DB
{
    public class NManager
    {
        // Сборка, из которой решистрируются типы
        private Assembly assembly;
        private ISession session;

        // Этот обработчик нужен, чтобы Reflection нашел типы данных
        private Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            return assembly;
        }

        public void SetAssembly(Assembly pluginAssembly)               
        {
            assembly = pluginAssembly;
        }

        public NManager()
        {

        }

        public NManager(Assembly pluginAssembly, string s)
        {
            assembly = pluginAssembly;
            ConnectToDatabase(s);
            
        }

        public bool ConnectToDatabase(string path)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.AssemblyResolve += new ResolveEventHandler(MyResolveEventHandler);

            try
            {
                Configuration cfg = new Configuration();
                //string path = Application.StartupPath + @"\plugins\Wastes\Vehicle\VehicleDB.db";
                IDictionary<string, string> properties = new Dictionary<string, string>
			                                         	{
			                                         		{"connection.driver_class", "NHibernate.Driver.SQLite20Driver"},
			                                         		{"dialect", "NHibernate.Dialect.SQLiteDialect"},
			                                         		{"connection.provider", "NHibernate.Connection.DriverConnectionProvider"},
			                                         		{"connection.connection_string", "Data Source=" + path + ";Version=3" },
															{"proxyfactory.factory_class", @"NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle"}
			                                         	};

                cfg.SetProperties(properties);
                cfg.AddAssembly(assembly);
                
                ISessionFactory sessions = cfg.BuildSessionFactory();
                session = sessions.OpenSession();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                session.Close();
                currentDomain.AssemblyResolve -= new ResolveEventHandler(MyResolveEventHandler);
                return false;
            }
            currentDomain.AssemblyResolve -= new ResolveEventHandler(MyResolveEventHandler);
            return true;
        }

        public ISession GetSession()
        {
            return session;
        }

        public void CloseSession()
        {
            if (session != null && session.IsConnected)
            {
                //session.Flush();
                session.Close();
            }
        }
    }
}


