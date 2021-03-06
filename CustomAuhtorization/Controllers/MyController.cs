﻿using CustomAuhtorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuhtorization.Controllers
{
    public class MyController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [StinoAuthorizeAttribute(WhatMyName="Stino")]
        public ActionResult NoAccess()
        {
            return View();
        }

        public ActionResult Redirect()
        {
            return View();
        }

    }
}
