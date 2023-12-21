using System.Reflection;
using System;
using System.Xml.Linq;

namespace Arvidsson_Mattias_Labration4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Skapar en lista för att lagra personer
            List<Person> Personlist = new List<Person>();

            // Flaggar för att kontrollera när programmet ska avslutas
            bool menu = false;

            // Huvudloop för programmet
            while (!menu)
            {
                // Huvudmenyn
                Console.WriteLine(
                    "\n------------------------------" +
                    "\nChoose one of the options: " +
                    "\n1.) Add person " +
                    "\n2.) Print out list of added people " +
                    "\n3.) Exit the program. " +
                    "\n------------------------------"
                    );
                // Läsr användarens val
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                // Hanterar användarens val med en switch-sats
                switch (choice)
                {
                    // Anropar metoden för att lägga till en person
                    case 1:
                        AddPerson(Personlist);
                        break;

                    // Anropar metoden för att lista personer
                    case 2:
                        ListPerson(Personlist);
                        break;

                    // Sätter flaggan för att avsluta programmet
                    case 3:
                        menu = true;
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Try again. ");
                        break;
                }
            }
        }
        // Metod för att lägga till en person i listan
        static void AddPerson(List<Person> personsList)
        {
            // Flaggar för att kontrollera korrekt inmatning
            bool validInput = false;

            // Loop för att hantera felaktig inmatning och lägga till en person
            while (!validInput)
            {
                try
                {
                    // Läser in information om personen
                    Console.WriteLine("\nEnter information about the person: ");

                    Gender gender;
                    while (true)
                    {
                        // Hanterar inmatning för kön
                        Console.WriteLine("Gender (0: Male, 1: Female, 2: Non-binary, 3: Other): ");
                        Console.Write("Enter your choice: ");
                        if (Enum.TryParse(Console.ReadLine(), out gender) && Enum.IsDefined(typeof(Gender), gender))
                        {
                            break;
                        }
                        Console.WriteLine("\nInvalid input. Choose between 0 and 3. Please try again. ");
                    }

                    int hairLength;
                    while (true)
                    {
                        // Läser in och validera hårlängd
                        Console.WriteLine("\nHair length: ");
                        if (int.TryParse(Console.ReadLine(), out hairLength) && hairLength >= 0)
                        {
                            break;
                        }
                        Console.WriteLine("\nInvalid input. It needs to be a number. Please try again. ");
                    }

                    string hairColor;
                    while (true)
                    {
                        // Läser in och validera hårfärg
                        Console.WriteLine("\nHair color: ");
                        hairColor = Console.ReadLine() ?? "";
                        if (!string.IsNullOrWhiteSpace(hairColor) && !hairColor.Any(char.IsDigit))
                        {
                            break;
                        }
                        Console.WriteLine("\nInvalid input. It needs to be a color. Please try again. ");
                    }

                    int birthYear;
                    while (true)
                    {
                        // Läser in och validera födelseår
                        Console.WriteLine("\nBirthyear (YYYY): ");
                        if (int.TryParse(Console.ReadLine(), out birthYear) && birthYear > 1899 && birthYear < 2024 )
                        {
                            break;
                        }
                        Console.WriteLine("\nInvalid input. Valid years are 1900-2023. Please try again. ");
                    }

                    int birthMonth;
                    while (true)
                    {
                        // Läser in och validera födelsemånad
                        Console.WriteLine("\nBirthmonth (MM): ");
                        if (int.TryParse(Console.ReadLine(), out birthMonth) && birthMonth > 0 && birthMonth < 13 )
                        {
                            break;
                        }
                        Console.WriteLine("\nInvalid input. Valid month are 1-12. Please try again. ");
                    }

                    int birthDay;
                    while (true)
                    {
                        // Läser in och validera födelsedag
                        Console.WriteLine("\nBirthday (DD): ");
                        if (int.TryParse(Console.ReadLine(), out birthDay) && birthDay > 0 && birthDay < 32 )
                        {
                            break;
                        }
                        Console.WriteLine("\nInvalid input. Valid days are 1-31. Please try again. ");
                    }

                    string eyeColor;
                    while (true)
                    {
                        // Läser in och validera ögonfärg
                        Console.WriteLine("\nEye color: ");
                        eyeColor = Console.ReadLine() ?? "";
                        if (!string.IsNullOrWhiteSpace(eyeColor) && !eyeColor.Any(char.IsDigit))
                        {
                            break;
                        }
                        Console.WriteLine("\nInvalid input. It needs to be a color. Please try again. ");
                    }

                    // Skapar en ny person och lägg till i listan
                    Person newPerson = new Person(gender, hairLength, hairColor, birthYear, birthMonth, birthDay, eyeColor);
                    personsList.Add(newPerson);

                    Console.WriteLine("\nPerson added!");

                    // Markerar korrekt inmatning och avsluta loopen
                    validInput = true;
                }
                // Hanterar olika typer av fel och ge lämpliga meddelanden
                catch (FormatException)
                {
                    Console.WriteLine("\nIncorrect format. Please try again. ");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("\nInvalid input. Please try again. ");
                }
                catch (Exception)
                {
                    Console.WriteLine("\nSomething went wrong. Please try again. ");
                }
            }
        }
        // Metod för att skriva ut en lista av personer till konsolen
        static void ListPerson(List<Person> personsList)
        {
            Console.WriteLine("\nList of people: \n");

            // Loopar igenom varje person i listan och skriv ut deras information
            foreach (var person in personsList)
            {
                Console.WriteLine(person + "\n");
            }
        }
    }
}