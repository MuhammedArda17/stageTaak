namespace InimcoApi.Services;

using InimcoApi.Models;

public class PersonService
{
    private static readonly char[] Vowels = "aeiouAEIOU".ToCharArray();

    // Telt het aantal klinkers in voor- en achternaam
    public int CountVowels(Person person)
    {
        string fullName = person.FirstName + person.LastName;
        return fullName.Count(c => Vowels.Contains(c));
    }

    // Telt het aantal medeklinkers in voor- en achternaam
    public int CountConsonants(Person person)
    {
        string fullName = person.FirstName + person.LastName;
        return fullName.Count(c => char.IsLetter(c) && !Vowels.Contains(c));
    }

    // Draait voor- en achternaam om
    public string ReverseName(Person person)
    {
        string reversed1 = new string(person.FirstName.Reverse().ToArray());
        string reversed2 = new string(person.LastName.Reverse().ToArray());
        return $"{reversed2} {reversed1}";
    }

    // Bouwt het volledige resultaat object
    public PersonResult BuildResult(Person person)
    {
        return new PersonResult
        {
            VowelCount = CountVowels(person),
            ConsonantCount = CountConsonants(person),
            FullName = $"{person.FirstName} {person.LastName}",
            ReversedName = ReverseName(person),
            Person = person
        };
    }
}