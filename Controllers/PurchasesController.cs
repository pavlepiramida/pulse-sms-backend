using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Pulse.Controllers
{
    [ApiController]
    [Route("api/v1/purchases")]
    public class PurchasesController : ControllerBase
    {
        private readonly ILogger<PurchasesController> _logger;

        public PurchasesController(ILogger<PurchasesController> logger)
        {
            _logger = logger;
        }

        [HttpPost("record")]
        public void record([FromQuery] string type)
        {
            //Not needed
        }
    }
}
