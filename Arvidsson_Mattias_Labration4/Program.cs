using System.Reflection;
using System;
using System.Xml.Linq;

namespace Arvidsson_Mattias_Labration4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> Personlist = new List<Person>();

            bool shouldExit = false;

            while (!shouldExit)
            {
                Console.WriteLine(
                    "\n------------------------------------------------" +
                    "\nChoose one of the options: " +
                    "\n1.) Add person " +
                    "\n2.) Print out list of people " +
                    "\n5.) Exit the program. " +
                    "\n------------------------------------------------"
                    );

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPerson(Personlist);
                        break;
                        
                    case 2:
                        ListPersons(Personlist);
                        break;

                    case 3:
                        shouldExit = true;
                        break;
                        
                    default:
                        Console.WriteLine("Invalid selection. Try again.");
                        break;
                }

            }

        static void AddPerson(List<Person> personsList)
            {
                Console.WriteLine("\nEnter information about the person: ");

                Console.WriteLine("Enter gender (0: Male, 1: Female, 2: Non-binary, 3: Other): ");
                Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());

                Console.WriteLine("Enter hair length in cm: ");
                int hairLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter hair color: ");
                string hairColor = Console.ReadLine();

                Hair hair = new Hair { HairLength = hairLength, HairColor = hairColor };

                Console.WriteLine("Enter birthday (ÅÅÅÅ-MM-DD): ");
                DateTime birthday = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter eye color: ");
                string eyeColor = Console.ReadLine();

                Person newPerson = new Person(gender, hair, birthday, eyeColor);
                personsList.Add(newPerson);

                Console.WriteLine("Person added!");
            }

            static void ListPersons(List<Person> personsList) 
            {
                Console.WriteLine("\nList of people:");

                foreach (var person  in personsList)
                {
                    Console.WriteLine(person + "\n");
                }
            }
        }
    }
}