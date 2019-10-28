using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using ActiveWriter_SQL_Server.db;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;



namespace frmActiveWriter_SQL_Server
{
    public partial class frmActiveWriter_SQL_Server : Form
    {
      



        public frmActiveWriter_SQL_Server()
        {
            InitializeComponent();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ActiveRecordStarter.ResetInitializationFlag();

            IDictionary<string, string> properties = new Dictionary<string, string>
            {
                {"connection.driver_class", "NHibernate.Driver.SqlClientDriver"},
                {"dialect", "NHibernate.Dialect.MsSql2008Dialect"},
                {"connection.provider", "NHibernate.Connection.DriverConnectionProvider"},
                
                
                //Catalog Name Table. Как создать БД с помощью метода ActiveRecordStarter.CreateSchema();
                //пока выяснить не удалось но CreateSchema() прекрасно добавляет таблицы к БД
                {"connection.connection_string", "Data Source=PC;Initial Catalog=vvv;Integrated Security=True"},
                {
                    "proxyfactory.factory_class",
                    @"NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle"
                }
            };



            try
            {

                InPlaceConfigurationSource source = new InPlaceConfigurationSource();
                source.Add(typeof(ActiveRecordBase), properties);

                ActiveRecordStarter.Initialize(source, MainDBHelper.GetTypes());

                ActiveRecordStarter.CreateSchema();




            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.ToString());

            }
        }


    }
}
