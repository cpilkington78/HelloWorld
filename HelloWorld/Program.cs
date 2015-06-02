using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "HELLO WORLD!";
            string mySecondString = "Hope you have a nice day!";

            Console.WriteLine("Your message is {0} to all who are out there.", myString);
            Console.WriteLine(mySecondString);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
