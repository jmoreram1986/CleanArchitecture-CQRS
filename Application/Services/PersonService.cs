using Application.DTOs;
using Application.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<PersonDTO>> GetAllAsync()
        {
            var personsCollection = await _personRepository.GetAllAsync();
            var response = personsCollection.Select(x => _mapper.MapPersonToPersonDTO(x)).ToList();
            return response;
        }

        public async Task<PersonDTO> GetByIdAsync(int id)
        {
            var person = await _personRepository.GetByIdAsync(id);
            var response = _mapper.MapPersonToPersonDTO(person);
            return response;
        }
    }
}
