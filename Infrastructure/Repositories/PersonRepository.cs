using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AdventureWorksContext _context;

        public PersonRepository(AdventureWorksContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Person>> GetAllAsync()
        {
            return await _context.People.Take(100).ToListAsync();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _context.People.Where(x => x.BusinessEntityId == id).FirstOrDefaultAsync();
        }
    }
}
