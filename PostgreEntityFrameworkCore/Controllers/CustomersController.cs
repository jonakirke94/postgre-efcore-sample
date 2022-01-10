using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PostgreEntityFrameworkCore.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreEntityFrameworkCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly DemoDbContext _context;

        public CustomersController(DemoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<CustomerEntity> Get()
        {
            var query = _context.Customers;

            var queryString = query.ToQueryString();

            return query;
        }
    }
}
