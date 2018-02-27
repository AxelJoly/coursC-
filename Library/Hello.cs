using System;


namespace Library
{
    public class Hello
    {
        private static string _World;

        public static string World { get; set; }
            = "Hello World";


        public static string Greet(string name)
        {
            var time = DateTime.Now.ToString("HH:mm");
            var message = $"Hello {name}, it is {time}.";
            
            return message;
        }

        public static string GreetUpper(string name)
        {
            var message = Greet(name.ToUpper());
            return message;
        }
        
    }
}