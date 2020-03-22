using System;
using System.Diagnostics;
using System.Linq;

namespace ProjectTime.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // 控制台程序的基本输入输出
            Console.WriteLine("Hello Project Time~");
            Console.WriteLine("Please Input Sth:");

            string input = Console.ReadLine();

            // 字符串分割与剔除空项
            var items = input.Split(new char[] { ' ', ',' })
                                .Where( 
                                        item => !string.IsNullOrEmpty(item)
                              ).ToList();
            Debugger.Break();
             
        }
    }
}