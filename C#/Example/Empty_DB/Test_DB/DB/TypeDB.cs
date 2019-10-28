using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test_DB.DB
{
    public struct TypeInDB
    {
        public static Type[] TypeInSpace()
        {
            return Assembly.GetExecutingAssembly().GetTypes().Where(t => String.Equals(t.Namespace, t.Namespace, StringComparison.Ordinal)).ToArray();
        }



    }
}
