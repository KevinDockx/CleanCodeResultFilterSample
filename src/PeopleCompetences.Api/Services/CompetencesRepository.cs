using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeopleCompetences.Api.DataStore;

namespace PeopleCompetences.Api.Services
{
    public class CompetencesRepository : ICompetencesRepository
    {
        private readonly CompetencesStore _competencesStore;

        public CompetencesRepository(CompetencesStore competencesStore)
        {
            _competencesStore = competencesStore ?? throw new ArgumentNullException(nameof(competencesStore));
        }
        public IEnumerable<Competence> GetCompetences(int personId)
        {
            return _competencesStore.Competences.Where(c => c.PersonId == personId);
        }
    }
}
