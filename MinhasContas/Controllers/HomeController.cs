using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhasContas.Models;

namespace MinhasContas.Controllers
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
            List<Register> registers = new List<Register>();
            registers.Add(new Register("Conta de Luz", "Enel", 89.50, DateTime.Now, new DateTime(2020, 10, 25), new DateTime(2020, 10, 19)));
            registers.Add(new Register("Conta de Agua", "Sabesp", 150.50, DateTime.Now, new DateTime(2020, 10, 25), new DateTime(2020, 10, 19)));
            return View(registers);
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
