using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using Test_DB.DB;

namespace Test_DB.Class_for_DB
{
    public class cConnect
    {
        public void Init (string tmpFileDB)
        {
            ActiveRecordStarter.ResetInitializationFlag();

            IDictionary<string, string> properties = new Dictionary<string, string>
            {
                {"connection.driver_class", "NHibernate.Driver.SQLite20Driver"},
                {"dialect", "NHibernate.Dialect.SQLiteDialect"},
                {"connection.provider", "NHibernate.Connection.DriverConnectionProvider"},
                {"connection.connection_string", "Data Source=" + tmpFileDB + ";locked=true"},
                {
                    "proxyfactory.factory_class",
                    @"NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle"
                }
            };



            try
            {

                InPlaceConfigurationSource source = new InPlaceConfigurationSource();
                source.Add(typeof(ActiveRecordBase), properties);

                ActiveRecordStarter.Initialize(source, TypeInDB.TypeInSpace());


            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());

            }
        }

        public void Create_DB()
        {

            try
            {
                ActiveRecordStarter.CreateSchema();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }

        }
    }
}
