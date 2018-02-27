

using System;
using Library.Implementation;

namespace Library.Models
{
    public class Person
    {
        public int? Id { get; set; }
        public string name  { get; set; }
        public string firstName  { get; set; }
        public string lastName  { get; set; }
        public DateTime? birthDate  { get; set; }
        public City city { get; set; }
        
        public int Age()
            => (DateTime.Now - birthDate.Value).Days / 365;
        
        
        public override string ToString()
            => $"{firstName} {lastName}: {Id} from {city}";
    }
}