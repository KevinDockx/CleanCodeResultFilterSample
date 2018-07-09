using AutoMapper;
using System.Collections.Generic;

namespace PeopleCompetences.Api
{
    public class PeopleCompetencesProfile : Profile
    {
        public PeopleCompetencesProfile()
        {
            CreateMap<DataStore.Competence, Models.Competence>();

            CreateMap<DataStore.Person, Models.Person>()
                .ForMember(dest => dest.FullName, 
                           opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

            // Mappings to combine a Person with an IEnumerable of Competences into 
            // one PersonWithCompetences
            CreateMap<DataStore.Person, Models.PersonWithCompetences>()
                .ForMember(dest => dest.FullName, 
                           opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

            CreateMap<IEnumerable<DataStore.Competence>, Models.PersonWithCompetences>()
                .ForMember(dest => dest.Competences, 
                           opt => opt.MapFrom(src => src));
        }
    }
}
