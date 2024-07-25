using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Model(string car, int year)
        {
            Car car1 = new Car { car = car, year = year };

            return View(car1);
        }

    }
}
