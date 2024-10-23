namespace Controllers;

using Microsoft.AspNetCore.Mvc;
using Services;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public IActionResult GetAdultUsers()
    {
        try
        {
            var users = _userService.GetAdultUsers();
            return Ok(users);
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}
