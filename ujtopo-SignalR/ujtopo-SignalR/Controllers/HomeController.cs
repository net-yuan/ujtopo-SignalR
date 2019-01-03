﻿using System.Threading.Tasks;
using System.Web.Mvc;
using ujtopo.SignalR.Services;

namespace ujtopo.SignalR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Designer()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public async Task<ActionResult> Chart()
        {
            var chartService = new ChartService();
            return View(await chartService.GetCount());
        }
    }
}