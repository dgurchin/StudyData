using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonadaMaybe
{
    public static class Maybe
    {
        public static TResult With<TInput, TResult>(this TInput o, Func<TInput,TResult> evaluator )
           where TInput: class where TResult: class
        {
            if (o == null) return null;
            return evaluator(o);
        }

        public static TResult Return<TInput, TResult>(this TInput o, Func<TInput, TResult> evaluator,TResult failureValue)
            where TInput : class
        {
            if (o == null) return failureValue;
            return evaluator(o);
        }

        public static bool ReturnSuccess<TInput>(this TInput o)
             where TInput : class
        {
            return o != null;
        }

        public static TInput If<TInput>(this TInput o, Predicate<TInput> evaluator)
            where TInput : class
        {
            if (o == null) return null;
            return evaluator(o) ? o : null;
        }

        public static TInput Do<TInput>(this TInput o, Action<TInput> action)
            where TInput : class
        {
            if (o == null) return null;
            action(o);
            return o;
        }
    }

    public class Person
    {
        public Adress Adress { get; set; }
    }

    public class Adress
    {
        public string HouseName { get; set; }
    }



    public class MyClass
    {
        public MyClass()
        {
            
        }

        public bool HasHouseName(Person person)
        {
            return person.With(p => p.Adress)
                .With(p => p.HouseName)
                .If(x=>x.Length>4)
                .Do(Console.WriteLine)
                .ReturnSuccess();
        }
    }
}
