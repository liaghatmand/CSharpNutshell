using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConstraints
{
    //We use Generics if we have one functionality with diffrent paramater types
    //We use <T> for class if we have too many generic methods
    public class DisplayUtil
    {
        public void DisplayValue<T>(T value)
            //where T : struct
            //where T : class //any reference type
            //where T : class? //nullable
            //where T : notnull
            //where T : class , new() // a reference type with default parameterless constructor
            //where T : class, IPerson // It has to implement IPerson
            //where T : Enum

        {
            Console.WriteLine($"The Value is: {value}");
        }

        //we can have two parameters
        //for every parameter we can have one constraint (where)
        public void DisplayValue<T,U>(T value, U SecondValue)
            where T : struct
            where U : class

        {
            Console.WriteLine($"The Value is: {value}");
            Console.WriteLine($"The Value is: {SecondValue}");
        }
    }
}