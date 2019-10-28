using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacesText
{
    public class cMain
    {

        [Description("{List_Prodution1}")]
        public IList<cListProperty> lstProductions { get; set; }



        [Description("{List_Prodution}")]
        public string Productions { get; set; }

    


        public cMain()
        {
            Productions = "YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY";

            cListProperty oListProperty = new cListProperty();

            oListProperty.Name = "Хуня";

            oListProperty.Count = "Дохуя";

            oListProperty.Measurement = "От хуя";

            lstProductions = new List<cListProperty>();

            lstProductions.Add(oListProperty);


            oListProperty = new cListProperty();

            oListProperty.Name = "Пизда";

            oListProperty.Count = "Пиздатая";

            oListProperty.Measurement = "Глубина";

            lstProductions.Add(oListProperty);



            



        }

        public void Replace()
        {
            string s = "{List_Prodution}";

            foreach (var VARIABLE in GetType().GetProperties())
            {

                s = s.Replace(
                    ((DescriptionAttribute) GetType().GetProperty(VARIABLE.Name)
                        .GetCustomAttributes(typeof (DescriptionAttribute), true)[0]).Description,
                    VARIABLE.GetValue(this).ToString());




            }



            Debug.WriteLine(s);
        }
    }
}

