using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCBasics.Models;
using MVCBasics.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            _logger.LogInformation("Hallo voin HomeController!!!!!!!!!!!!!!!!!!!!!!!!!");
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            PrivacyVM privacyVM = new(); // = PrivacyVM privacyVM = new PrivacyVM();

            return View(privacyVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
