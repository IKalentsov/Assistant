namespace Assistant.Application.Common.Interfaces
{
    /// <summary>
    /// Работа с текущим пользователем
    /// </summary>
    public interface IAuthCurrentUser
    {
        bool IsLoggedIn();
    }
}
