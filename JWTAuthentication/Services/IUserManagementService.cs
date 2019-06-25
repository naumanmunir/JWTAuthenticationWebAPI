using JWTAuthentication.Models;

namespace JWTAuthentication.Services
{
    public interface IUserManagementService
    {
        bool IsUserValid(User user);
    }
}