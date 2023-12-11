using System.Reflection;
using System;
using System.Xml.Linq;

namespace Arvidsson_Mattias_Labration4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Hårdkodade värden för en person
            Person person1 = new Person(
                Gender.Woman,
                new Gender { HairLength = 45, HairColor = "Blonde" },
                new DateTime(1989, 7, 21),
                "Green"
            );

            // Skriv ut personens information med Console.WriteLine
            Console.WriteLine("Information about the person:");
            Console.WriteLine(person1.ToString());

        }
    }
}