﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewEmployeesActions.Models;

namespace NewEmployeesActions.Controllers
{
    //これはコメントです
    //commentcomment
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //コミットテストとプッシュテスト
        //ojpsdorjpoerjpojadopirjgeorjap:ogje
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
