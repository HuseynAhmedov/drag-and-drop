﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
