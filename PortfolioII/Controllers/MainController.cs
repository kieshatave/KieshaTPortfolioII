using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioII.Controllers
{
    public class MainController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpGet("/Projects")]
        public IActionResult Projects()
        {
            return View();
        }
    }
}