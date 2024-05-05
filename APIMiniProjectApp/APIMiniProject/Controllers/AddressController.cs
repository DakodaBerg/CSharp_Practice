using APIMiniProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private ILogger _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] AddressModel data)
        {
            _logger.LogInformation("The address was logged as {address}", data);
        }
    }
}
