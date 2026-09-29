using AspCoreWithJQuery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspCoreWithJQuery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public float Add(float number1, float number2)
        {
            return number1 + number2;
        }

        [HttpPost]
        public float Subtract(float number1, float number2)
        {
            return number1 - number2;
        }


        [HttpPost]
        public Calculatioin Calculate(float number1, float number2)
        {
            Calculatioin model=new Calculatioin();
            model.Add=number1+number2;
            model.Subtract = number1 - number2;
            model.Multiply = number1 * number2;
            model.Division = (double)number1 / number2;
            return model;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
