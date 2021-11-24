using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    class Generic
    {

        //This method created for maximum string value
        public static string MaxValue(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)      //comparing values to each other by using compareTo keyword
            {
                return first;                                                  //returning value if condition is true
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            return default;
        }
    }
}