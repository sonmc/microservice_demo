using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OcelotApiGateway.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            var orders = new List<Order>{
                new Order{ OrderId = 1, OrderDate = DateTime.Now, CustomerId = 1},
                new Order{ OrderId = 2, OrderDate = DateTime.Now, CustomerId = 2},
                new Order{ OrderId = 3, OrderDate = DateTime.Now, CustomerId = 1}
            };
            return Ok(orders);
        }
    }
}
