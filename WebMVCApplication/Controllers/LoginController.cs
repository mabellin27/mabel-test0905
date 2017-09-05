using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCApplication.Models;

namespace WebMVCApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel loginModel)
        {
            if (!ModelState.IsValid)
                return View("Index");
            if (loginModel.UserName == "abc")
            {
                ViewBag.Show = "login!!!";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "User name is not correct.");
                return View("Index");
            }
        }
        public ActionResult ResetPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ResetPassword(ResetPasswordViewModel resetModel)
        {
            
            return View("Index");
        }
    }
}