﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Elastic_Kibana_DotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Elastic_Kibana_DotNetCore.Controllers {
    public class HomeController : Controller {
        private ILogger<HomeController> _logger;

        public HomeController (ILogger<HomeController> logger) {
            _logger = logger;
        }
        public IActionResult Index () {
            var a="aa";
            _logger.LogInformation ($"Index");
            _logger.LogError("ooooppsss");
                        _logger.LogCritical("ooooppsss critical");

            return View ();
        }

        public IActionResult Privacy () {
            _logger.LogInformation ($"Privacy");
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}