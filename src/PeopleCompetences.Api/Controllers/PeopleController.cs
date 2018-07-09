using Microsoft.AspNetCore.Mvc;
using PeopleCompetences.Api.Filters;
using PeopleCompetences.Api.Services;
using System;

namespace PeopleCompetences.Api.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleRepository _peopleRepository;
        private readonly ICompetencesRepository _competencesRepository;

        public PeopleController(IPeopleRepository peopleRepository, ICompetencesRepository competencesRepository)
        {            
            _peopleRepository = peopleRepository 
                ?? throw new ArgumentNullException(nameof(peopleRepository));
            _competencesRepository = competencesRepository
                ?? throw new ArgumentNullException(nameof(competencesRepository));
        }

        [HttpGet("{personId}")]
        // Apply a result filter - this takes care of manipulating the output, so no mapping code
        // has to be in the controller actions
        //
        // The result filter can be reused for any action that requires returning the same type of 
        // output, eg: after a successful PUT, PATCH or POST
        [PeopleWithCompetencesResultFilter]
        public IActionResult GetPersonWithCompetences(int personId)
        {
            var person = _peopleRepository.GetPerson(personId);
            var competences = _competencesRepository.GetCompetences(personId);

            // use a ValueTuple structure to pass the person and competences to the 
            // ResultFilter
            return Ok((person, competences));
        }
    }
}
