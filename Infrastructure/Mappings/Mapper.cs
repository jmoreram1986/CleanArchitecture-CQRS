using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mappings
{
    public class Mapper : IMapper
    {
        public PersonDTO MapPersonToPersonDTO(Person person)
        {
            var response = new PersonDTO()
            {
                Id = person.BusinessEntityId,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Title = person.Title
            };

            return response;
        }
    }
}
