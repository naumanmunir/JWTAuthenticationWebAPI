namespace JWTAuthentication.Models
{
    public interface IAuthenticateSerivce
    {
        bool IsAuthenticated(User user, out string token);
    }
}