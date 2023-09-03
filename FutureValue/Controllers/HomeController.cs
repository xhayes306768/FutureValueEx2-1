﻿using FutureValue.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            //ViewBag.Name = "Mary";
            //  ViewBag.FV = 99999.99;
            ViewBag.FV = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            ViewBag.FV = model.CalculateFutureValue(); return View(model);
        }
    }
}
