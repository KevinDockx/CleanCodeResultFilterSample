using PeopleCompetences.Api.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleCompetences.Api.Services
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly PeopleStore _peopleStore;

        public PeopleRepository(PeopleStore peopleStore)
        {
            _peopleStore = peopleStore ?? throw new ArgumentNullException(nameof(peopleStore));
        }

        public Person GetPerson(int personId)
        {
            return _peopleStore.People.FirstOrDefault(p => p.Id == personId);
        }
    }
}
