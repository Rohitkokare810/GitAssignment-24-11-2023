﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("hello, {0}",name);
            Console.ReadKey();
        }
    }
}