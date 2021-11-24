using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    class Generic<T> where T : IComparable           //Icomparable keyword is used for identify compareTo method in generics
    {
        private T first, second, third;             //declaring instance variable

        public Generic(T first, T second, T third)  //declaring parameterized constructor
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        //This method created for maximum string value
        public static T MaxValue(T first, T second, T third)
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

        public T MaximumValue()
        {
            T max = Generic<T>.MaxValue(this.first, this.second, this.third);
            return max;
        }

    }
}