using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CustomerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            var customers = new List<Customer>{
                new Customer{ CustomerId = 1, CustomerName = "Onik"},
                new Customer{ CustomerId = 2, CustomerName = "mizan"}
            };
            return Ok(customers);
        }
    }
}
