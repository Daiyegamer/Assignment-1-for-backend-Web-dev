using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Assignment1backendweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase



    {
        [HttpGet(template: "cube/{base}")]
        //GET : localhost:xx/api/q3/cube/base = 4 -> 64
        //GET : localhost:xx/api/q3/cube/base = -4 -> -64
        //GET : localhost:xx/api/q3/cube/base = 10 -> 1000
        //<summary>
        //<returns>a cube of {base}</returns>
        //<summary>


        public int cube(int Base)

        {
            int cube = (Base * Base * Base);
            return cube;



        }
    }
}
