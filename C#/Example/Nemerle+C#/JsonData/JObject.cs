using System;
using System.Linq;
using System.Collections.Generic;

namespace JsonData
{
    public abstract class JObject {
        public class Object : JObject { 
            public Dictionary<string,JObject> Properties { get; set; }

            #region ToString
            public override string ToString()
            {
                return "{" + string.Join (
                    ", ",
                    Properties.Select(
                      x => x.Key.ToJsonString() + " : " + x.Value.ToString()
                    ).ToArray()
                ) + "}";
            }
            #endregion
        }
        
        public class Array : JObject { 
            public List<JObject> Items { get; set; }

            #region ToString
            public override string ToString()
            {
                return "[" + string.Join(
                    ", ",
                    Items.Select(x => x.ToString()).ToArray()
                ) + "]";
            }
            #endregion
        }
        
        public class Value : JObject { 
            public JValue Data { get; set; }

            #region ToString
            public override string ToString()
            {
                return Data.ToString();
            }
            #endregion
        }

        public static JObject.Object CreateObject() { 
            return new Object { Properties = new Dictionary<string,JObject>() }; 
        }
        public static JObject.Array CreateArray() { 
            return new Array { Items = new List<JObject>() }; 
        }
        public static JObject.Value CreateValue(JValue value) { 
            return new Value { Data = value }; 
        }
    }
}
