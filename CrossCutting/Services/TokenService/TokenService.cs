using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CrossCutting.Services.TokenService
{
    public static class TokenService
    {
        public static string Secret = "43efe49b9dfe8fdcc7ffb4bb42e3437ffbe113298348ec7f00a8b5159b3c28a5";
        public static string GenerateToken(PopulateToken populateToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(TokenClaim.Id, populateToken.Id.ToString()),
                    new Claim(TokenClaim.Name, populateToken.Name),
                    new Claim(TokenClaim.Email, populateToken.Email),
                    new Claim(TokenClaim.PrivateEmail, populateToken.PrivateEmail),
                    new Claim(TokenClaim.IsAdmin, populateToken.Admin.ToString()),
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var roles = populateToken.Roles.Where(role => !string.IsNullOrEmpty(role)).ToList();

            tokenDescriptor.Subject.AddClaim(new Claim(TokenClaim.Roles, string.Join(',', roles)));

            var tokenWriter = tokenHandler.CreateToken(tokenDescriptor);
            string token = tokenHandler.WriteToken(tokenWriter);
            return token;
        }
    }
}
