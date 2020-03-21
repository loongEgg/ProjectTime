using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTime.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Project Time~");
            Console.WriteLine("Please Input Sth:");

            string input = Console.ReadLine();
            var items = input.Split(new char[] { ' ', ',' }).Where( item => !string.IsNullOrEmpty(item)).ToList();
            Debugger.Break();
        }
    }
}
