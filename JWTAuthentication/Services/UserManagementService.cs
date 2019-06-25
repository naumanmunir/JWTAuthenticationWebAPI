using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAuthentication.Models;

namespace JWTAuthentication.Services
{
    public class UserManagementService : IUserManagementService
    {
        public bool IsUserValid(User user)
        {
            if (user != null && !string.IsNullOrEmpty(user.Username) && !string.IsNullOrEmpty(user.Password))
            {
                return true;
            }

            return false;
        }
    }
}
