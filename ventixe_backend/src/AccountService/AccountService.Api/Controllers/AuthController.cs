using AccountService.Business.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        private readonly IAuthService _authService;

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] SignUpFormData formData)
        {
            if (!ModelState.IsValid)       
                return BadRequest(ModelState);

            var result = await _authService.SignUpAsync(formData);
            return result.Succeeded
                ? Ok(result) 
                : Problem(result.Message);

        }
    }
}
