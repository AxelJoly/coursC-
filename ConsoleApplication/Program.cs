using System;
using Library;
using Library.Implementation;
using Library.Models;

namespace ConsoleApplication
{
    internal class Program
    {
       
        
        public static void Main(string[] args)
        {
            Console.WriteLine(Hello.GreetUpper("Axel"));
            var result =  Hello.World;
            
            Console.WriteLine(result);
            
            var person = new Person();
            person.Id = 1;
            person.firstName = "Axel";
            person.lastName = "Joly";
            person.birthDate = new DateTime(1995, 01, 02);
            var city = new City();
            city.Id = 1;
            city.name = "Sanary";
            person.city = city;
            Console.WriteLine(person);
            Console.WriteLine(person.Age());
        }
    }
}