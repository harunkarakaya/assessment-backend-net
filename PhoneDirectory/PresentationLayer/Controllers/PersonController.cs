﻿using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public void Create(string a)
        {
            
        }
    }
}
