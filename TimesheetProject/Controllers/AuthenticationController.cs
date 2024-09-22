using Admin_UserJWTExample.Generate_Function;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimesheetProject.Data;
using TimesheetProject.Model;

namespace TimesheetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        public IConfiguration _configuration;
        public ActivityDbContext dbContext;
        public AuthenticationController(IConfiguration configuration, ActivityDbContext _dbContext)
        {
            _configuration = configuration;
            dbContext = _dbContext;
        }
        [HttpPost("register")]
        public IActionResult RegisterDetails(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> PostLoginDetails(User user)
        {
            if (user != null)
            {      

                var result = dbContext.Users.Where(t => t.UserName == user.UserName && t.Password == user.Password).FirstOrDefault();
                if (result == null)                   
                {
                    return BadRequest("Invalid Credentials");
                }
                else
                {
                    user.UserMessage = "Login Success";
                    user.AccessToken = GenerateToken.GetToken(user, _configuration);
                    return Ok(user);
                }
            }
            return BadRequest();
        }

    }
}
