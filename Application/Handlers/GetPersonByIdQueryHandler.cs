using Application.DTOs;
using Application.Interfaces;
using Application.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, PersonDTO>
    {
        private readonly IPersonService _personService;

        public GetPersonByIdQueryHandler(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<PersonDTO> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return await _personService.GetByIdAsync(request.PersonId);
        }
    }
}
