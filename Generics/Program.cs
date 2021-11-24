using System;

namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling generic class by creating object
            int[] arr = { 213, 133, 121, 133, 545, 633 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.PrintMaxValue();
            Console.ReadLine();
        }
    }
}
