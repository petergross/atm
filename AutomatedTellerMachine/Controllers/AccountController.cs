using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNet.Identity.Owin;
using System.Net;

namespace AutomatedTellerMachine.Controllers
{
    
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            //AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }

        //[HttpPost]       
        [AllowAnonymous]
        public ActionResult Register()
        {
            //AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}