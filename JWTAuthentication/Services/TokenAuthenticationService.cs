using JWTAuthentication.Services;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
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

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenManagement.Value.Secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(

                tokenManagement.Value.Issuer,
                tokenManagement.Value.Audience,
                claim,
                expires:DateTime.Now.AddMinutes(tokenManagement.Value.AccessExpiration),
                signingCredentials: creds
            );

            token = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            return true;
        }
    }
}
