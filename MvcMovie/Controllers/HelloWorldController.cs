using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, string numtimes)
        {
            var sb = new StringBuilder();
            var total = int.Parse(numtimes);
            for (var i = 0; i < total; i++)
            {
                sb.Append(name);
            }
            return HtmlEncoder.Default.Encode(sb.ToString());
        }
    }
}
