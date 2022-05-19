using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZAI.Server.Database;
using ZAI.Server.Services;

namespace ZAI.Server.Controllers;
[Route("api/user")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ZAIDbContext _dbContext;
    private readonly UserService _userService;

    public UserController(ZAIDbContext dbContext, UserService userService)
    {
        this._dbContext = dbContext;
        this._userService = userService;
    }

    [HttpGet, Route("users")]
    public IActionResult GetUsersData()
    {
        var users = _userService.GetUser();

        if (users != null && users.Any())
            return Ok(users);

        return BadRequest();
    }
    [HttpGet, Route("user/{id}")]
    public IActionResult GetUserData(int id)
    {
        var userData = _userService.GetUser(id);

        if (userData != null)
            return Ok(userData);

        return BadRequest();
    }
    [HttpGet, Route("user/token/{token}")]
    public IActionResult GetUserData(string token)
    {
        var userData = _userService.GetUser(token);

        if (userData != null)
            return Ok(userData);

        return BadRequest(userData);
    }
}

