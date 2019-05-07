﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Vidly.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //[OutputCache(Duration =50,Location =OutputCacheLocation.Server,VaryByParam ="*")]//how to enable caching; 
                                                                                         //* means for any combination of these parameters we'll have a different version in the cache
        [OutputCache(Duration = 0, VaryByParam = "*", NoStore =true)]//how to disable caching; 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}