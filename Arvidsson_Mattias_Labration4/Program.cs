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
                    "\n3.) Exit the program. " +
                    "\n------------------------------------------------"
                    );

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPerson(Personlist);
                        break;

                    case 2:
                        ListPerson(Personlist);
                        break;

                    case 3:
                        shouldExit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Try again. ");
                        break;
                }
            }
        }
        static void AddPerson(List<Person> personsList)
        {
            bool validInput = false;

            while (!validInput)
            {
                try
                {
                    Console.WriteLine("\nEnter information about the person: ");

                    Gender gender;
                    while (true)
                    {
                        Console.WriteLine("Gender (0: Male, 1: Female, 2: Non-binary, 3: Other): ");
                        if (Enum.TryParse(Console.ReadLine(), out gender) && Enum.IsDefined(typeof(Gender), gender))
                        {
                            break;
                        }
                        Console.WriteLine("Invalid input. Please try again. ");
                    }

                    int hairLength;
                    while (true)
                    {
                        Console.WriteLine("Hair length: ");
                        if (int.TryParse(Console.ReadLine(), out hairLength) && hairLength >= 0)
                        {
                            break;
                        }
                        Console.WriteLine("Invalid input. Please try again. ");
                    }

                    string hairColor;
                    while (true)
                    {
                        Console.WriteLine("Hair color: ");
                        hairColor = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(hairColor))
                        {
                            break;
                        }
                        Console.WriteLine("Invalid input. Please try again. ");
                    }

                    int birthYear;
                    while (true)
                    {
                        Console.WriteLine("Birthyear (YYYY): ");
                        if (int.TryParse(Console.ReadLine(), out birthYear) && birthYear > 2023 && birthYear < 1900)
                        {
                            break;
                        }
                        Console.WriteLine("Invalid input. Please try again. ");
                    }

                    int birthMonth;
                    while (true)
                    {
                        Console.WriteLine("Birthmonth (MM): ");
                        if (int.TryParse(Console.ReadLine(), out birthMonth) && birthMonth > 12 && birthMonth < 1)
                        {
                            break;
                        }
                        Console.WriteLine("Invalid input. Please try again. ");
                    }

                    int birthDay;
                    while (true)
                    {
                        Console.WriteLine("Birthday (DD): ");
                        if (int.TryParse(Console.ReadLine(), out birthDay) && birthDay > 31 && birthDay < 1)
                        {
                            break;
                        }
                        Console.WriteLine("Invalid input. Please try again. ");
                    }

                    string eyeColor;
                    while (true)
                    {
                        Console.WriteLine("Eye color: ");
                        eyeColor = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(eyeColor))
                        {
                            break;
                        }
                        Console.WriteLine("Invalid input. Please try again. ");
                    }

                    Person newPerson = new Person(gender, hairLength, hairColor, birthYear, birthMonth, birthDay, eyeColor);
                    personsList.Add(newPerson);

                    Console.WriteLine("Person added!");

                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect format. Please try again. ");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid input. Please try again. ");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong. Please try again. ");
                }
            }
        }
        static void ListPerson(List<Person> personsList)
        {
            Console.WriteLine("\nList of people: ");

            foreach (var person in personsList)
            {
                Console.WriteLine(person + "\n");
            }
        }
    }
}