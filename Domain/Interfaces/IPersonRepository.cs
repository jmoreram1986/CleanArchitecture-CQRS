using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPersonRepository
    {
        Task<ICollection<Person>> GetAllAsync();
        Task<Person> GetByIdAsync(int id);
    }
}