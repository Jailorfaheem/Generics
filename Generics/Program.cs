using System;

namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double output = Generic.MaxNumber(15.16, 16.27, 7.23);
            Console.WriteLine("{0} is a maximum number ", output);
            Console.ReadLine();

        }
    }
}
