﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace FrontEndThinkBridge1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}