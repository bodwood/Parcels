using Microsoft.AspNetCore.Mvc;
using parcelApp.Models;

namespace parcelApp.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() {
      return View();
    }
  }
}