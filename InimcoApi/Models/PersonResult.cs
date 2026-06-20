namespace InimcoApi.Models;

public class PersonResult
{
    public int VowelCount { get; set; }
    public int ConsonantCount { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string ReversedName { get; set; } = string.Empty;
    public Person Person { get; set; } = new();
}