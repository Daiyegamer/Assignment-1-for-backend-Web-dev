using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace Assignment1backendweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5 : ControllerBase
    {
        [HttpPost(template: "secret")]

        public string secret([FromBody] int requestBody)
        {
            return $"Shh..the secret is {requestBody}";
        }

        /// <summary>
        /// Receives an HTTP POST request with a body and provides a response message.
        /// </summary>
        /// <returns>An HTTP response with a body echoing the request body.</returns>
        ///POST http://localhost:7000/api/q5/secret->"Shh...the secret is 5

    }
}
