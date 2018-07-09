using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleCompetences.Api.Services
{
    public interface ICompetencesRepository
    {
        IEnumerable<DataStore.Competence> GetCompetences(int personId);
    }
}
