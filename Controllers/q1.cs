using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1backendweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        //GET : localhost:xx/api/q1/welcome -> "Welcome to 5125!"
        [HttpGet(template:"Welcome")]
        public string q1()
        {
            return "Welcome to 5125!";

        }
    }
}