using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacesText
{
    public sealed class cListProperty
    {
        [Description("{Production_Name}")]
        public string Name { get; set; }

        [Description("{Production_Count}")]
        public string Count { get; set; }

        [Description("{Production_Measurement}")]
        public string Measurement { get; set; }



        
    }
}
