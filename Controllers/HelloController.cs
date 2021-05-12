using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
  public class HelloController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      string html = "<form method='post'>" +
        "<input type='text' name='name' />" +
        "<input type='submit' value='Greet me!' />" +
        "</form>";

      return Redirect("/Hello/Goodbye");
    }

    [Route("/Hello")]
    [HttpPost]
    public IActionResult Display(string name = "World")
    {
      return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
    }

    [Route("/Hello/{name}")]
    public IActionResult Index2(string name)
    {
      return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
    }
    
    public IActionResult Goodbye()
    {
      return Content("Goodbye");
    }
  }
}