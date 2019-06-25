using JWTAuthentication.Services;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JWTAuthentication.Models
{
    public class TokenAuthenticationService : IAuthenticateSerivce
    {
        private readonly IUserManagementService userManagementService;
        private readonly IOptions<TokenManagement> tokenManagement;

        public TokenAuthenticationService(IUserManagementService userManagementService, IOptions<TokenManagement> tokenManagement)
        {
            this.userManagementService = userManagementService;
            this.tokenManagement = tokenManagement;
        }

        public bool IsAuthenticated(User user, out string token)
        {
            token = string.Empty;

            if (!userManagementService.IsUserValid(user)) return false;

            var claim = new[]
            {
                new Claim(ClaimTypes.Name, user.Username)
            };



            throw new NotImplementedException();
        }
    }
}
