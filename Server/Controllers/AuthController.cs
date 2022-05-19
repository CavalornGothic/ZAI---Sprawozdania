using JWT.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZAI.Server.Database;
using ZAI.Server.Services;
using ZAI.Shared.DTO;

namespace ZAI.Server.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ZAIDbContext _dbContext;
        private readonly AuthService _authService;
        private readonly UserService _userService;

        public AuthController(IConfiguration configuration, ZAIDbContext dbContext, AuthService authService, UserService userService)
        {
            this._configuration = configuration;
            this._dbContext = dbContext;
            this._authService = authService;
            this._userService = userService;
        }
        
        [HttpPost, Route("signin")]
        public IActionResult SignIn([FromBody] SignInRequestDTO user )
        {
            if (String.IsNullOrEmpty(user.Login) || String.IsNullOrEmpty(user.Password))
                return BadRequest(new SignInResponseDTO { Message = "Type your username or password" });

            var userExists = _dbContext.Users.Where(x => x.Login == user.Login).ToList();
            if (!userExists.Any())
                return BadRequest(new SignInResponseDTO { Message = "User not exists" });

            if (!BCrypt.Net.BCrypt.Verify(user.Password, userExists.First().PasswordHash))
                return BadRequest(new SignInResponseDTO { Message = "Incorrect password"});

            SignInResponseDTO response = new SignInResponseDTO
            {
                AccessToken = _authService.GenerateJWToken(userExists.First()),
                RefreshToken = _authService.GenerateJWToken(userExists.First(), AuthService.TokenType.Refresh),
                Roles = _userService.GetUserRoles(_dbContext.Users.Where(x => x.Login == user.Login).First().Id),
            };
            return Ok(response);
        }
    }
}
