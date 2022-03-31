using Microsoft.AspNetCore.Mvc;
using Vehicles.Models;

namespace Vehicles.Controllers
{
    public class CarController : Controller
    {
        [HttpGet]
        public ActionResult Display()
        {
            Car car = new Car() {Make="Ford", Model="Capri", EngineType=CarEngineType.Petrol, EngineSize=1600 };
            return View(car);
        }
    }
}
