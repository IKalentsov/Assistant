using FluentValidation;

namespace Assistant.Application.Auth.Commands.RegisterUser
{
    public class RegisteruserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisteruserCommandValidator() 
        {
            RuleFor(registerUserCommand => registerUserCommand.Email).NotEmpty().WithMessage((v) => "Email не должен быть пустой");
            RuleFor(registerUserCommand => registerUserCommand.Password).NotEmpty().WithMessage((v) => "Пароль не должен быть пустой");
            RuleFor(registerUserCommand => registerUserCommand.FirstName).NotEmpty().WithMessage((v) => "Поле имя не должно быть пустsм");
            RuleFor(registerUserCommand => registerUserCommand.LastName).NotEmpty().WithMessage((v) => "Поле фамилия не должно быть пустsм");
            RuleFor(registerUserCommand => registerUserCommand.Login).NotEmpty().WithMessage((v) => "Поле логин не должно быть пустsм");
        }
    }
}
