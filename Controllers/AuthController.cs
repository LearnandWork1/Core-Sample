using CoreSample.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NuGet.Common;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CoreSample.Controllers
{
    [Route("api/Auth")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        [HttpPost, Route("login")]
        public IActionResult Login([FromBody] LoginModel user)
        {
            if (user == null)
                return BadRequest("Invalid Client Request");

            if (user.UserName == "johndoe" && user.Password == "def@123")
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("supersecretkey@12345678910supersecretkey"));
                var SigningCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokenOptions = new JwtSecurityToken(
                    issuer: "http://localhost:7053",
                    audience: "http://localhost:7053",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: SigningCredentials);

                var tokenstring = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(new {Token= tokenstring });
            }
            return Unauthorized();
        }



    }
}
