using EFCoreApi.Models.DbModels;
using EFCoreApi.Models.OutputModels;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EFCoreApi.Infrastructure
{
    public class Token : IToken
    {
        private readonly IConfiguration _config;

        public Token(IConfiguration config)
        {
            _config = config;
        }

        public TokenDto Create(User user) => GenerateJSONWebToken(user);

        private TokenDto GenerateJSONWebToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);


            var claims = new Claim[]
            {
                new Claim("UserId",user.Id.ToString(),typeof(int).ToString()),
                new Claim("UserName",user.UserName),
                new Claim("RoleName",user.Role.RoleName),
                new Claim("RoleId",user.Role.Id.ToString(),typeof(int).ToString()),
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(5),
              signingCredentials: credentials);

            return new TokenDto()
            {
                Name = user.UserName,
                Role = user.Role.RoleName,
                ExpirationDate = token.ValidTo,
                ExpirationInMs = (token.ValidTo - token.ValidFrom).TotalMilliseconds,
                Token = new JwtSecurityTokenHandler().WriteToken(token)
            };
        }
    }
}
