using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkLegacy
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeObject someObject = new SomeObject(42);
            Console.WriteLine($"Hello, World: {someObject}");
        }
    }
}
