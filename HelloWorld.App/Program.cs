using HelloWorld.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Greeter();
            var greeting = greeter.GetGreeting("Victor");
            Console.WriteLine("Hello World!");
       }
    }
}
