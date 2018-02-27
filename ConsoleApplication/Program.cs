using System;
using Library;

namespace ConsoleApplication
{
    internal class Program
    {
       
        
        public static void Main(string[] args)
        {
            Console.WriteLine(Hello.GreetUpper("Axel"));
            string result =  Hello.World;
            
            Console.WriteLine(result);
        }
    }
}