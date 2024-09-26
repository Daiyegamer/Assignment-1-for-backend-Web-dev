using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1backendweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6 : ControllerBase

    ///simplified the area formula into an integer which came out to=>(2.598076211353316) x (side)^2
    ///
    {
        [HttpGet(template: "Hexagon")]
        public double hexagon(double side)



        {
            double multiplier = 2.598076211353316;
            double area = ( multiplier * side * side);
            return  area;

        }

    }
}
