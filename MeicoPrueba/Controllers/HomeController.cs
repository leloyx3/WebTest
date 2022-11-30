using MeicoPrueba.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace MeicoPrueba.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult SumNum(string firstNumber, string secondNumber)
        {
            int Sum = 0;
            DataResult dataresult = new();
            try
            {
                bool firstNumberb = long.TryParse(firstNumber, out long c);
                bool secondNumberb = long.TryParse(secondNumber, out long a);
                if (!firstNumberb || !secondNumberb)
                {
                    return RedirectToAction("Error", "Home");
                }
                Sum = int.Parse(firstNumber) + int.Parse(secondNumber);
                if (Sum <= 0)
                {
                    return View("Index");
                }
                dataresult.Sumatoria = Sum;
            }
            catch (Exception)
            {

            }
            return View("Result", dataresult);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}