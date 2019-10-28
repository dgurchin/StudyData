using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeControl
{
    class Option<T> 
    {
        public Option(T value) { Value = value; }
        public T Value { get; set; }
    }
    
    class Program
    {
        static int Fact(int n) 
        {
            if (n == 0) return 1;
            var pre = Fact(n - 1);
            return n * pre;
        }

        static IEnumerable<Option<int>> CoFact(int n)
        {
            if (n == 0)
            {
                yield return new Option<int>(1);
                yield break;
            }
            yield return null;
            var pre = default(int);
            foreach (var item in CoFact(n - 1))
            {
                if (item == null) 
                    yield return null;
                else 
                    pre = item.Value;
            }
            yield return null;
            yield return new Option<int>(n*pre);
        }
        
        
        static void Main(string[] args)
        {
            //Console.WriteLine(Fact(-1));

            var counter = 0;
            foreach (var item in CoFact(5))
            {
                if (item == null)
                {
                    counter++;
                    if (counter == 10)
                    {
                        Console.WriteLine("overtime");
                        break;
                    }
                }
                else Console.WriteLine(item.Value);
            }

            Console.ReadLine();
        }
    }
}
