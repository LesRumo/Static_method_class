using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_method_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static method is about the class itself
            //Math is part of C# packages
            Console.WriteLine(Math.Sqrt(144));

            // UseFullTools tools = new UseFullTools() if u make the class static as well, u will only access it will direct methods?????

            UseFullTools.sayHi("Lesedi");

            Console.ReadLine();
        }
    }
}
