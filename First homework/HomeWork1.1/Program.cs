using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClasses
{
    class someFunctions
    {
        static void Print(string message)
        {
            Console.WriteLine(message);
        }
        static void Pause()
        {
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Print something");
            string message = Console.ReadLine();
            Print(message);
            Pause();
        }
    }
}
