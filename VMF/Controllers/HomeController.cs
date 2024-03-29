﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VMF.Models;

namespace VMF.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost("submit")]
        public IActionResult submit(Survey newSurvey){
            ViewBag.currentSurvey = newSurvey;
            return View();
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
