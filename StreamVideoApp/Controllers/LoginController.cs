using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StreamVideoApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{

        public LoginController()
        {
            
        }

        [HttpGet]
        public string HealthCheck()
        {
            return "Working Fine";
        }

    }
}
