using Application.DTOs;
using Application.Interfaces;
using Application.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : BaseController
    {
        // GET: api/<PersonController>
        [HttpGet]
        public async Task<IEnumerable<PersonDTO>> Get()
        {
            var query = new GetAllPersonQuery();
            var result = await Mediator.Send(query);
            return result;
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<PersonDTO> Get(int id)
        {
            var query = new GetPersonByIdQuery()
            {
                PersonId = id
            };

            var response = await Mediator.Send(query);
            return response;
        }
    }
}
