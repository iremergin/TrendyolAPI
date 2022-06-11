using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkaController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> markaListeleme(string marka)
        {
            WebRequest request = HttpWebRequest.Create("https://api.trendyol.com/sapigw/brands/by-name?name=" + marka);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string Marka_JSOn = reader.ReadToEnd();



            return Ok(Marka_JSOn);
        }

    }
}
