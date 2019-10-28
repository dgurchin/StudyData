using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public sealed class cProperty
    {

        [Description("{Name}")]
        public string Name { get; set; }

        [Description("{SurName}")]
       
        public string SurName { get; set; }

        [Description("{LastName}")]
        public string LastName { get; set; }


        public string replace(string aaa)
        {

            foreach (var VARIABLE in GetType().GetProperties())
            {
                if (VARIABLE.GetValue(this) == null)
                {
                    aaa = aaa.Replace(
                        ((DescriptionAttribute)GetType().GetProperty(VARIABLE.Name)
                       .GetCustomAttributes(typeof(DescriptionAttribute), true)[0]).Description, "");
                }
                else
                {
                    aaa = aaa.Replace(((DescriptionAttribute) GetType().GetProperty(VARIABLE.Name).
                        GetCustomAttributes(typeof (DescriptionAttribute), true)[0]).Description,
                        VARIABLE.GetValue(this).ToString());

                }

            }

            return aaa;
        }

    }
}
