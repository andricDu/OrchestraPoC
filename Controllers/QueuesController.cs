using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using OrchestraPoc.Models;

namespace OrchestraPoc.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueuesController : ControllerBase
    {

        private readonly ILogger<QueuesController> _logger;
        private readonly OrchestraDbContext _context;

        public QueuesController(ILogger<QueuesController> logger, OrchestraDbContext context) {
            _logger = logger; 
            _context = context;
        }

        [HttpPost]
        public void Post([FromBody] Models.Queue queue)
        {
            _context.Queues.Add(queue);
            _logger.LogInformation("Created a new Queue: { queue } ", queue.ToString());
            _context.SaveChanges();
        }

    }

}
