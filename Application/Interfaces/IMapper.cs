using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IMapper
    {
        PersonDTO MapPersonToPersonDTO(Person person);
    }
}