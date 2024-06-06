using Assistant.Application.Common.Interfaces;

namespace Assistant.Infrastructure.Services
{
    public class AuthCurrentUser : IAuthCurrentUser
    {
        public AuthCurrentUser() 
        {
        }

        public bool IsLoggedIn()
        {
            return false;
        }
    }
}
