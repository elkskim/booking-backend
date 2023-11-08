using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace booking_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {

        private readonly ILogger<ResourceController> _logger;

        public ResourceController(ILogger<ResourceController> logger)
        {
            _logger = logger;
        }

        

    }
}
