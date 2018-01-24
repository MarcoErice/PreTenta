using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using PreTenta.Interfaces;
using PreTenta.Models;


namespace PreTenta.Controllers
{
    public class HomeController : Controller
    {
        private iTimeProvider timeProvider;
        
        public HomeController(iTimeProvider _timeProvider)
        {
            timeProvider = _timeProvider;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AddOneMonth()
        {
            timeProvider.Now = timeProvider.Now.AddMonths(1);
            ViewBag.Time = timeProvider.Now.ToString();
            return View("Index");
        }
        public IActionResult SubtractOneMonth()
        {
            timeProvider.Now = timeProvider.Now.AddMonths(-1);
            ViewBag.Time = timeProvider.Now.ToString();
            return View("Index");
        }
        public IActionResult ToSwedish()
        {
            var code = "sv-SE";
            var key = CookieRequestCultureProvider.DefaultCookieName;
            var value = CookieRequestCultureProvider.MakeCookieValue(
                new RequestCulture(code));
            Response.Cookies.Append(key, value);
            return RedirectToAction("Index");
        }
        public IActionResult ToEnglish()
        {
            var code = "en-US";
            var key = CookieRequestCultureProvider.DefaultCookieName;
            var value = CookieRequestCultureProvider.MakeCookieValue(
                new RequestCulture(code));
            Response.Cookies.Append(key, value);
            return RedirectToAction("Index");
        }
    }
}
