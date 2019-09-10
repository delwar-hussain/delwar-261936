using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "";
            Console.WriteLine("Please Enter your name:");
            Name = Console.ReadLine();

            string Age = "";
            Console.WriteLine("How old are you:");
            Age = Console.ReadLine();

            string Address = "";
            Console.WriteLine("Please Enter your Address:");
            Address = Console.ReadLine();

            string Contact = "";
            Console.WriteLine("Please Enter your Contact Number:");
            Contact = Console.ReadLine();

            Console.Write(Name+ Age +Address +Contact);
            Console.ReadKey();
        }
    }
}
