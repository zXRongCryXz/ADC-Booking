﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADCGroup_WebUI.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutMe
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ADCGroup()
        {
            return View();
        } 
    }
}