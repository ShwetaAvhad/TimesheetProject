
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TimesheetProject.Model;

namespace Admin_UserJWTExample.Generate_Function
{
    public class GenerateToken
    {
        public static string GetToken(User user, IConfiguration _configuration)
        {
            var Claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,_configuration["Jwt:Subject"]),
                new Claim("UserId",user.Id.ToString()),
                new Claim("UserName",user.UserName)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                Claims,
                expires: DateTime.UtcNow.AddDays(10),
                signingCredentials: signIn);

            var Token = new JwtSecurityTokenHandler().WriteToken(token);
            return Token;
        }
    }
}
