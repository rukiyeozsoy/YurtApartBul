﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yurt_Apart_Bul.Models.Siniflar;
namespace Yurt_Apart_Bul.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.AnaSayfas.ToList();
            return View(degerler);
        }
    }
}