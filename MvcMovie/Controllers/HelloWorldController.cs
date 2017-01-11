﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name,int numTimes )
        {

            ViewBag.numTimes = numTimes;
            ViewBag.Message = "Hello "+ name;
            return View();
        }
        public ActionResult NewFeature()
        {
            return View();
        }
        public ActionResult SeconFeatureAdded()
        {
            return View();
        }
    }
}