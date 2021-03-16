using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries
{
    public class GetAllPersonQuery : IRequest<ICollection<PersonDTO>>
    {
    }
}
