﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeaToSkyCabinsApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        
        public ActionResult Signup()
        {
            return View();
        }

        public ActionResult SignupOwner()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Properties()
        {
            return View();
        }
        //Property One
        public ActionResult PropertyDetails()
        {
            return View();
        }
        //Property Two
        public ActionResult AlpineMeadows()
        {
            return View();
        }
        //Property Three
        public ActionResult Blackcomb()
        {
            return View();
        }

        public ActionResult WhistlerCreek()
        {
            return View();
        }
    }
}