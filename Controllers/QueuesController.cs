using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace OrchestraPoc.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueuesController : ControllerBase
    {

        private readonly ILogger<QueuesController> _logger;

        public QueuesController(ILogger<QueuesController> logger) {
            _logger = logger; 
        }

        [HttpPost]
        public void Post([FromBody] Models.Queue queue)
        {
            _logger.LogInformation("Created a new Queue: { queue } ", queue.ToString());
        }

    }

}
