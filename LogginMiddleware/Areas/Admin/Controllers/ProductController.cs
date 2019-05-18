﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogginMiddleware.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
