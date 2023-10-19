using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Assistant.Application.Auth.Commands.RegisterUser;

namespace AssistantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ApiController
    {
        public AuthController(IMediator mediator)
            : base(mediator) { }

        [HttpPost("register")]
        public async Task<IActionResult> Login(RegisterUserCommand query, CancellationToken cancellationToken)
        {
            var dto = await Mediator.Send(query, cancellationToken);

            return Ok(dto);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(RegisterUserCommand query, CancellationToken cancellationToken)
        {
            var dto = await Mediator.Send(query, cancellationToken);

            return Ok(dto);
        }

        [HttpGet("check")]
        [Authorize]
        public IActionResult Check()
        {
            return Ok();
        }
    }
}
