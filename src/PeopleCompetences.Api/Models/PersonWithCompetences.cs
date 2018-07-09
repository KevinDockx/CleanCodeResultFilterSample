using System.Collections.Generic;

namespace PeopleCompetences.Api.Models
{
    public class PersonWithCompetences : Person
    {
        public IEnumerable<Competence> Competences { get; set; } = new List<Competence>();
    }
}
