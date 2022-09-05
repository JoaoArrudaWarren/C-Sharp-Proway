using Data.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Data.Utils
{
    public class JWTTokenUser
    {
        private readonly IConfiguration config;

        public JWTTokenUser(IConfiguration config)
        {
            this.config = config;
        }

        public string CreateToken(Usuario user)
        {
            string tok = string.Empty;

            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Name));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));

            var key = config.GetSection("AppSettings:TokenKey").Value;
            var key2 = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(key));
            var cred = new SigningCredentials(key2, SecurityAlgorithms.HmacSha512Signature);

            var expiration = DateTime.Now.AddDays(1);

            var token = new JwtSecurityToken(claims: claims, expires: expiration, signingCredentials: cred);

            tok = new JwtSecurityTokenHandler().WriteToken(token);

            return tok;
        }

    }
}
