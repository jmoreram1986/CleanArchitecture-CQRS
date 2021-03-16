using Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPersonService
    {
        Task<ICollection<PersonDTO>> GetAllAsync();
        Task<PersonDTO> GetByIdAsync(int id);
    }
}