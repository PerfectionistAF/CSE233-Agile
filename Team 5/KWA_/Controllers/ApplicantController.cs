﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KWA.Models;

namespace KWA.Controllers
{
    public class ApplicantController:Controller
    {
        public ActionResult Apply()
        {
            return View();
        }
    }
}