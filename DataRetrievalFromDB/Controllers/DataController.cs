using DataRetrievalFromDB.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataRetrievalFromDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private ApiDbContext _dbContext;

        public DataController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<DataController>
        [HttpGet]
        public async Task <IActionResult> Get()
        {
            return Ok(await _dbContext.Orders.ToListAsync());
        }

        // GET api/<DataController>/Get/5
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var order = await _dbContext.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound("No record found matching this ID (" + id + ")");
            } else
            {
                return Ok(order);
            }
        }
    }
}
