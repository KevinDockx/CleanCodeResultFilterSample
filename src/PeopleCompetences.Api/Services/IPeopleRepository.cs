using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleCompetences.Api.Services
{
    public interface IPeopleRepository
    {
        DataStore.Person GetPerson(int personId);
    }
}
