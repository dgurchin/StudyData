using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveWriter_SQL_Server.db
{
    partial class ModelClass1
    {
        public static ModelClass1 byID(int ID_Air_Exist)
        {
            foreach (var VAR in FindAllByProperty("id", ID_Air_Exist))
            {
                if (VAR.id== ID_Air_Exist)
                {
                    return VAR;
                }
            }

            return null;
        }
    }
}
