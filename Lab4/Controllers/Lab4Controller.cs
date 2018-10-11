using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            ViewData["time"] = timeOfDay();
            DateTime date1 = DateTime.Now;
            return View(date1);
        }

        public string timeOfDay()
        {
            if (DateTime.Now.Hour < 12)
            {
                return "Good Morning";
            }
            else if (DateTime.Now.Hour < 18)
            {

                return "Good Afternoon";
            }

            else
            {

                return "Good Evening";
            }
        }

        public IActionResult Waff()
        {
            ViewData["time"] = timeOfDay();
            return View("Waff");
        }

    }
}