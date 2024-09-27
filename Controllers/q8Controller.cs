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
        ///Summary
        ///defined parameters for small and large
        ///small total = (small input) * 25.50
        ///large total = (large input) * 40.50
        ///small total + large total = Subtotal
        ///tax = .13 * subtotal
        ///subotal + tax = Total with tax
        ///Summary end
        ///input parameter 1 = Small
        ///input parameter 2 = Large
        ///example if small =1 and Large = 1 We get the total as 66
        ///example if small =2 and Large = 4 We get the total as 240.69
        ///so the end point returns the total cost of all items including tax, in $ as 240.69
        {

            double SmallTotal = Math.Round(Small * 25.50,2);
            double LargeTotal = Math.Round(Large * 40.50,2);
            double Subtotal = Math.Round(SmallTotal + LargeTotal,2);
            double Tax = Math.Round(Subtotal * .13,2);
            double Total = Math.Round(Subtotal + Tax, 2);
            string message = $"{Small}  Small @ $25.50 = {SmallTotal.ToString("C", CultureInfo.CurrentCulture)};" 
                +$" {Large} Large @ $40.5  = {LargeTotal.ToString("C", CultureInfo.CurrentCulture)};"
                +$" Subtotal = {Subtotal.ToString("C", CultureInfo.CurrentCulture)};"
                + $" Tax = { Tax.ToString("C", CultureInfo.CurrentCulture)} HST;"
                + $" Total = {Total.ToString("C", CultureInfo.CurrentCulture)};";

            return message;
        }

    }
}
