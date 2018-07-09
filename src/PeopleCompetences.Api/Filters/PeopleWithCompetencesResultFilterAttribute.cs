using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PeopleCompetences.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleCompetences.Api.Filters
{

    public class PeopleWithCompetencesResultFilterAttribute : ResultFilterAttribute
    {
        public override async Task OnResultExecutionAsync(
            ResultExecutingContext context,
            ResultExecutionDelegate next)
        {
            var resultFromAction = context.Result as ObjectResult;
            if (resultFromAction?.Value == null
                || resultFromAction.StatusCode < 200
                || resultFromAction.StatusCode >= 300)
            {
                // when the result isn't an object result with a value
                // and a successful status code (level 200), don't map
                // and continue with the next delegate
                await next();
                return;
            }

            // cast ValueTuple from object
            var (person, competences) =
                ((DataStore.Person, IEnumerable<DataStore.Competence>))resultFromAction.Value;

            // map Person object into new PersonWithCompetences object
            var mappedPerson = Mapper.Map<PersonWithCompetences>(person);
            // map the competences into the mapped person object
            // results in a combined person with competences, which is set as value
            // for the object result
            resultFromAction.Value = Mapper.Map(competences, mappedPerson);
            
            // continue with the next delegate
            await next();
        }
    } 
}
