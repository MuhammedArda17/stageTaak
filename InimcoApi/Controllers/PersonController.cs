namespace InimcoApi.Controllers;

using InimcoApi.Models;
using InimcoApi.Services;
using InimcoApi.Repositories;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private readonly PersonService _personService;
    private readonly PersonRepository _personRepository;

    public PersonController()
    {
        _personService = new PersonService();
        _personRepository = new PersonRepository();
    }

    [HttpPost]
    public IActionResult Post([FromBody] Person person)
    {
        if (string.IsNullOrWhiteSpace(person.FirstName) || string.IsNullOrWhiteSpace(person.LastName))
            return BadRequest("voornaam en achternaam zijn verplicht.");

        _personRepository.Save(person);
        PersonResult result = _personService.BuildResult(person);
        return Ok(result);
    }
}