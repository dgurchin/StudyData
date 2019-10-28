using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonData
{
    static class Extentions
    {
        public static string ToJsonString(this string self) 
        {
            return "\"" + self.Replace("\"", "\\\"") + "\"";
        }
    }
}
