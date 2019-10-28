using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JsonParser;


namespace JsonUser
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser();
            var obj = parser.ParseAll(
                    @"[
                        {
                          ""foo"" : null,
                          ""array"" : [
                              null,
                              ""a"",
                              ""b""
                          ]
                        },
                        ""foo""
                      ]");
            Console.WriteLine(obj);
            Console.ReadLine();
        }
    }
}
