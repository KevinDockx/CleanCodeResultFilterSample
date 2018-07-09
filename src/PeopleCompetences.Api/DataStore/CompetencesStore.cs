using System.Collections.Generic;

namespace PeopleCompetences.Api.DataStore
{
    /// <summary>
    /// Dummy data store containing a few competences - image that this is coming from an external service call :-)
    /// </summary>
    public class CompetencesStore
    {
        public IEnumerable<Competence> Competences { get; private set; } =
            new List<Competence>()
            {
                new Competence() { Id = 1, PersonId = 1, Name =  "Reading" },
                new Competence() { Id = 2, PersonId = 1, Name =  "Cooking" },
                new Competence() { Id = 3, PersonId = 2, Name =  "Drinking wine" },
                new Competence() { Id = 4, PersonId = 2, Name =  "Watching movies" },
                new Competence() { Id = 5, PersonId = 3, Name =  "Playing soccer" },
                new Competence() { Id = 6, PersonId = 3, Name =  "Watching soccer" },
                new Competence() { Id = 7, PersonId = 4, Name =  "Travelling" },
                new Competence() { Id = 8, PersonId = 4, Name =  "Putting up tents at festivals" },
            };
    }
}
