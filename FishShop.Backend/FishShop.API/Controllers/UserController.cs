using FishShop.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FishShop.Core.Dtos;
using FishShop.Core.Dtos.Responses;
using Microsoft.AspNetCore.Http;

namespace FishShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<GlobalResponse> GetUser([FromBody]CreateUserRequest userRequest)
        {
            return await _userService.CreateUser(userRequest);
        }


    }
}
