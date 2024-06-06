using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AssistantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ApiController
    {
        public PingController(IMediator mediator)
            : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> Ping ()
        {
            return Ok(0);
        }
    }
}
