using APIMiniProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace APIMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private ILogger _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonModel data)
        {
            _logger.LogInformation("The person was logged as {person}", data);
        }
    }
}
