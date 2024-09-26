using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Globalization;

namespace Assignment1backendweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {

        [HttpPost(template: "SquashFellows")]
        [Consumes("application/x-www-form-urlencoded")]
        [Produces("application/json")]

        public string Squashfellows([FromForm] double Small, [FromForm]  double Large)
///defined parameters for small and large
///small total = (small input) * 25.5
///large total = (large input) * 40.5
///small total + large total = Subtotal
///tax = .13 * subtotal
///subotal + tax = Total with tax
        {
            
            double SmallTotal = Math.Round(Small * 25.50,2);
            double LargeTotal = Math.Round(Large * 40.50,2);
            double Subtotal = Math.Round(SmallTotal + LargeTotal,2);
            double Tax = Math.Round(Subtotal * .13,2);
            double Total = Math.Round(Subtotal + Tax, 2);
            string message = $"{Small}  Small @ $25.50 = ${SmallTotal};" 
                +$" {Large} Large @ $40.5  = ${LargeTotal};"
                +$" Subtotal = $ {Subtotal};"
                + $" Tax = ${ Tax} HST;"
                + $" Total = ${Total};";

            return message;
        }

    }
}
