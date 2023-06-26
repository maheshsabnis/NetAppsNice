using Core_APIApps.Models;
using Core_APIApps.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_APIApps.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthApiController : ControllerBase
    {
        AuthenticationInfraService service;

        public AuthApiController(AuthenticationInfraService service)
        {
            this.service = service; 
        }


        [HttpPost]
        [ActionName("register")]
        public async Task<IdentityResponse> CreateUserAsync(RegisterUser user)
        { 
            var response = await service.RegisterUserAsync(user);
            return response;
        }

        [HttpPost]
        [ActionName("auth")]
        public async Task<IdentityResponse> AuthUserAsync(LoginUser user)
        { 
            var response = await service.AuthUserAsync(user);
            return response;
        }
    }
}
