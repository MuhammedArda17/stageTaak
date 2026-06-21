namespace InimcoApi.Repositories;

using InimcoApi.Models;
using System.Text.Json;

public class PersonRepository
{
    private readonly string _filePath = "persons.json";

    public void Save(Person person)
    {
        List<Person> persons = GetAll();
        persons.Add(person);

        string json = JsonSerializer.Serialize(persons, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        File.WriteAllText(_filePath, json);
    }

    public List<Person> GetAll()
    {
        if (!File.Exists(_filePath))
            return new List<Person>();

        string json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<Person>>(json) ?? new List<Person>();
    }
}