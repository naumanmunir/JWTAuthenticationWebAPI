using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication.Models
{
    public class TokenAuthenticationService : IAuthenticateSerivce
    {
        public bool IsAuthenticated(User user, out string token)
        {
            throw new NotImplementedException();
        }
    }
}
