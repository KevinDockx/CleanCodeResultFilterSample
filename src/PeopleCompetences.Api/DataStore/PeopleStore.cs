using System.Collections.Generic;

namespace PeopleCompetences.Api.DataStore
{
    /// <summary>
    /// Dummy data store containing a few people - image that this is an EF Core context :-)
    /// </summary>
    public class PeopleStore
    {
        public IEnumerable<Person> People { get; private set; } =
            new List<Person>()
            {
                new Person() { Id = 1, FirstName = "Kevin", LastName = "Dockx" },
                new Person() { Id = 2, FirstName = "Sven", LastName = "Vercauteren" },
                new Person() { Id = 3, FirstName = "Tom", LastName = "Dockx" },
                new Person() { Id = 4, FirstName = "Nele", LastName = "Verheyen" },
            };
    }
}
