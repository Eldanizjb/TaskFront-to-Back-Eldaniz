using FoodWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FoodWeb.Controllers
{
    public class AboutController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }

      
    }
}
