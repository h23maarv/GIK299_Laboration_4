using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Arvidsson_Mattias_Labration4
{ 
    public class Person
{
    // Attribut för personens kön med en privat set-metod för att säkerställa inkapsling.
    public Gender Gender { get; private set; }
    // Attribut för personens hårdetaljer med en privat set-metod för att säkerställa inkapsling.
    public int HairLength { get; private set; }
    // Attribut för personens födelsedatum med en privat set-metod för att säkerställa inkapsling.
    public string HairColor { get; private set; }
    // Attribut för personens födelsedatum med en privat set-metod för att säkerställa inkapsling.
    public int BirthYear { get; private set; }
    // Attribut för personens ögonfärg med en öppen set-metod för att säkerställa inkapsling.
    public int BirthMonth { get; private set; }
    // Attribut för personens ögonfärg med en öppen set-metod för att säkerställa inkapsling.
    public int BirthDay { get; private set; }
    // Attribut för personens ögonfärg med en öppen set-metod för att säkerställa inkapsling.
    public string? EyeColor { get; private set; }

    // Konstruktor som används för att skapa en instans av Person med specificerade attribut.
    public Person(Gender gender, int hairLength, string hairColor, int birthYear, int birthMonth, int birthDay, string eyeColor)
    {
        Gender = gender;
        HairLength = hairLength;
        HairColor = hairColor;
        BirthYear = birthYear;
        BirthMonth = birthMonth;
        BirthDay = birthDay;
        EyeColor = eyeColor;
    }
    // Överskriden ToString-metod för att skapa en strängrepresentation av objektet.
    public override string ToString()
    {
        return  
            $"Gender: {Gender}\n" +
            $"Hair: Length - {HairLength}cm, Color - {HairColor}\n" +
            $"Birthday: {BirthYear}, {BirthMonth}, {BirthDay}\n" +
            $"Eyecolor: {EyeColor}";
    }
}
}