using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloAppController : ControllerBase
    {

        RegisterHelloBL _registerHelloBL;

        public HelloAppController(RegisterHelloBL registerHelloBL) 
        {
            _registerHelloBL = registerHelloBL;
        }


        [HttpGet]

        public string Get()
        {
            return _registerHelloBL.registration("value from controller");
        }

        

    }
}
