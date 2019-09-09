using System.Threading.Tasks;
using DaNetApi.Contracts.V1;
using DaNetApi.Contracts.V1.Requests;
using DaNetApi.Contracts.V1.Responses;
using DaNetApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DaNetApi.Controllers.V1
{
    public class AuthController : Controller
    {
        private readonly IIdentityService _authService;

        public AuthController(IIdentityService authService)
        {
            _authService = authService;
        }

        [HttpPost(ApiRoutes.Authaccess.Register)]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequest request)
        {
            var authResponse = await _authService.RegisterAsync(request.Email, request.Password);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                Token = authResponse.Token
            });
        }
    }
}