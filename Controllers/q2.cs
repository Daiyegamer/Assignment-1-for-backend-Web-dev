using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1backendweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        //example GET : localhost:xx/api/q2/Greeting?name=Gary ->"Hi Gary!"
        //example GET : localhost:xx/api/q2/Greeting?name=Gary ->"Hi Renée!"
        //<summary>
        //<returns>a greeting to {name}</returns>
        //<summary>
        /// <summary>
       
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>

        [HttpGet(template: "greeting")]
        public string greeting(string name)

        {
            string greeting = ("Hi " + name + "!");
            return (greeting);

        }
    }
}