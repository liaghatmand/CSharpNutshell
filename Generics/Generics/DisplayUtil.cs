using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //We use <T> for class if we have too many generic methods
    //otherwise we use it for method
    public class DisplayUtil<T>
    {
        public void DisplayValue(T value)
        {
            Console.WriteLine($"The Value is: {value}");
        }
    }
}
