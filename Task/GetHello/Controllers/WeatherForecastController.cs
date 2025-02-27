using Microsoft.AspNetCore.Mvc;

namespace GetHello.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloAppController : ControllerBase
    {
        
        public HelloAppController()
        {
            
        }

        [HttpGet]
        public string Get()
        {
            return "Welcome to Hello App";
        }

        [HttpGet]
        [Route("second")]
        public string Get1()
        {
            return "Welocme to second hellop app";
        }


    }
}
