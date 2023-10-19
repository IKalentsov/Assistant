using Assistant.Application.Common.Interfaces;
using Assistant.Domain.Entities;
using MediatR;

namespace Assistant.Application.Auth.Commands.RegisterUser
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Guid>
    {
        public RegisterUserCommandHandler(IAuthService authService)
        { 
            _authService = authService;
        }

        private readonly IAuthService _authService;

        public async Task<Guid> Handle(RegisterUserCommand registerUserCommand, CancellationToken cancellationToken)
        {
            var isUser = await _authService.CheckUserAsync(registerUserCommand.Email);

            if (!isUser) throw new Exception("Пользователь с таким email уже существует");

            var userId = await _authService.CreateUserAsync(
                new User()
                {
                    Email = registerUserCommand.Email,
                    Password = registerUserCommand.Password,
                    FirstName = registerUserCommand.FirstName,
                    LastName = registerUserCommand.LastName,
                    Login = registerUserCommand.Login,
                    Right = 0,
                });

            return userId;
        }
    }
}
