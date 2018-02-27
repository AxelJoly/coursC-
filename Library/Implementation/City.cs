using System;

namespace Library.Implementation
{
    public class City
    {
        public int Id { get; set; }
        public string name { get; set; }

        public string Display =>
            $"{name}: {Id}";

        public override string ToString()
            => Display;
    }
}