using System;

namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object of method and storing into variable
            Generic<int> obj = new Generic<int>(07, 03, 01);
            Generic<double> obj1 = new Generic<double>(24.22, 25.33, 43.25);
            Generic<string> obj2 = new Generic<string>("Capgemini", "TATA", "Infosys");

            //Display result
            Console.WriteLine("Maximum integer number : " + obj.MaximumValue());
            Console.WriteLine("maximum float number : " + obj1.MaximumValue());
            Console.WriteLine("maximum string value : " + obj2.MaximumValue());
            Console.ReadLine();
        }
    }
}
