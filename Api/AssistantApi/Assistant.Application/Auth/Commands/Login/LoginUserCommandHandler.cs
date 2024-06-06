using Assistant.Application.Common.Interfaces;
using MediatR;

namespace Assistant.Application.Auth.Commands.Login
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, Guid>
    {
        public LoginUserCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        private readonly IAuthService _authService;

        public async Task<Guid> Handle(LoginUserCommand userUserCommand, CancellationToken cancellationToken)
        {
           
            return Guid.Empty;
        }
    }
}
