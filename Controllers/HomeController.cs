using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TimeDisplay
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            DateTime now = DateTime.Now;

            @ViewBag.time = now.ToString("F");
            return View();
        }

    }
}