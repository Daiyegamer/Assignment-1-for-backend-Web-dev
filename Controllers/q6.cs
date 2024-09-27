using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace Assignment1backendweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6 : ControllerBase
    /// example GET http://localhost:7000/api/q6/hexagon?side=1 will give us the area as 2.598076211353316
    /// example GET http://localhost:7000/api/q6/hexagon?side=2 will give us the area as 10.392304845413264

    ///Returns the area of a regular hexagon with side length double
    ///{ S } using the formula.
    /// [(3*(root of 3))/3]*Side*Side

    //<summary>
    /// <param name="side"></param>
    /// <returns></returns>

    /// 
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
