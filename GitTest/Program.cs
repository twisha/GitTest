using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            Test1();
            Test2();
            TestFeature2();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static void Test1()
        {
            Console.WriteLine("Test1");
            Console.WriteLine("Test CheckIn 1");
        }

        static void Test2()
        {
            Console.WriteLine("Test2");
        }

        static void TestFeature2()
        {
            Console.WriteLine("TestFeature2");
            Console.WriteLine("TestCheckIn2");
            Console.WriteLine("TestCheckIn3");
        }
    }
}
