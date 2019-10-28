using System;

namespace JsonData
{
    public abstract class JValue
    {
        public class Null : JValue
        {
            #region ToString
            public override string ToString()
            {
                return "null";
            }
            #endregion
        }

        public class String : JValue 
        { 
            public string Value { get; set; }
            
            #region ToString
            public override string ToString()
            {
                return Value.ToJsonString();
            }
            #endregion
        }

        public static JValue CreateNull() { 
            return new Null(); 
        }
        public static JValue CreateString(string value) { 
            return new String { Value = value }; 
        }
    }
}
