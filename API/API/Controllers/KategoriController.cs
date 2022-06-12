using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> kategoriListeleme()
        {
            WebRequest requests = HttpWebRequest.Create("https://api.trendyol.com/sapigw/product-categories");
            WebResponse responses = requests.GetResponse();
            StreamReader readers = new StreamReader(responses.GetResponseStream());
            string Kategori_JSOns = readers.ReadToEnd();

            

            return Ok(Kategori_JSOns);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> kategoriArama(int id)
        {
            WebRequest requests = HttpWebRequest.Create("https://api.trendyol.com/sapigw/product-categories/"+id+"/attributes");
            WebResponse responses = requests.GetResponse();
            StreamReader readers = new StreamReader(responses.GetResponseStream());
            string Kategori_JSOns = readers.ReadToEnd();



            return Ok(Kategori_JSOns);
        }

    }
}
