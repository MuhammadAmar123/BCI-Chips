using BCI_Chips.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BCI_Chips.Controllers
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
        public IActionResult TechnologyTopic()
        {
            return View();
        }
        public IActionResult Opportunities()
        {
            return View();
        }
        public IActionResult Risks()
        {
            return View();
        }
        public IActionResult References()
        {
            return View();
        }
        public IActionResult Choices()
        {
            return View();
        }
        public IActionResult GuidelineConform()
        {
            return View();
        }
        public IActionResult MeetingMinutes()
        {
            return View();
        }
        public IActionResult TeamFormation()
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
