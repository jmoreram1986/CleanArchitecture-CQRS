using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
    public class GetPersonByIdQuery : IRequest<PersonDTO>
    {
        public int PersonId { get; set; }
    }
}
