﻿using Microsoft.AspNetCore.Mvc;

namespace ICECream.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
