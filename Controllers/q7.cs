using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1backendweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7 : ControllerBase
        //Get date.time code from link provided
        //datetime.now retrieves current date from computer->2024-09-22
        //currentdate = datetime.now
        //newdate=current date + (number of days)
        //newdate =answer in form of string(date format yyyy-mm-dd)
    {
        [HttpGet(template: "timemachine")]
        public string timemachine(double days)

        {
            DateTime currentdate = DateTime.Now;
            DateTime recalculateddate = currentdate.AddDays(days);
            string newdate = recalculateddate.ToString("yyyy-MM-dd");
            return newdate;


        }






    }
}
            
            
        

    




