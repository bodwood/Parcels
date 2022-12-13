using Microsoft.AspNetCore.Mvc;
using parcelApp.Models;

namespace parcelApp.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() {

      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcel/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int height, int width, int length, int weight){
      Parcel myParcel = new Parcel(height, width, length, weight);
      myParcel.doubleWeight();
      myParcel.VolumeTotal();
      return RedirectToAction("Index");
    }
  }
}