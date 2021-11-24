using System;

namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling function and storing into variable
            string output = Generic.MaxValue("Faheem", "solapur", "maharashtra");
            //Display Output
            Console.WriteLine("{0} is a maximum string value ", output);
            Console.ReadLine();

        }
    }
}