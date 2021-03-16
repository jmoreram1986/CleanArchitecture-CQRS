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
    public class GetPersonQueryHandler : IRequestHandler<GetAllPersonQuery, ICollection<PersonDTO>>
    {
        private readonly IPersonService _personService;

        public GetPersonQueryHandler(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<ICollection<PersonDTO>> Handle(GetAllPersonQuery request, CancellationToken cancellationToken)
        {

            return await _personService.GetAllAsync();
        }
    }
}
