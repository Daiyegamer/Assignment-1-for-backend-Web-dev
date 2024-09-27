using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1backendweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4 : ControllerBase


    /// <summary>
    /// Receives an HTTP POST request with an empty body and provides a response message.
    /// </summary>
    /// <returns>A "who's There? response </returns>
    /// POST : http://localhost:xx/api/q4/knockknock->"Who's there?"//
    /// <param input=""></param>
    /// <returns></returns>
    {
        [HttpPost (template:"knockknock")]
        public string KnockKnock()
        
            { 
            
            return " who's there?";
            }

        





    }
}
