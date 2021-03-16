using AdminProject.Models;
using AdminProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminProject.Controllers
{
    public class AuthorizeController : Controller
    {
        // GET: Authorize
        public ActionResult Index(string UserId, string Password)
        {
            AuthorizeModel oAuthorizeModel = new AuthorizeModel();
            AuthorizeRepository oAuthorizeRepository = new AuthorizeRepository();

            if (UserId == "admin@gmail.com" && Password=="admin@123")
            {
                return View("Admin");
            }
            else if (UserId == "customer@gmail.com" && Password == "customer@123")
            {
                return View("Customer");
            }
            else if (UserId == "employee@gmail.com" && Password == "employee@123")
            {
                return View("Employee");
            }
            else
            {
                return View();
            }

            
        }
        public ActionResult Admin()
        {
            return View();
        }
        public ActionResult Customer()
        {
            return View();
        }
        public ActionResult Employee()
        {
            return View();
        }

        public ActionResult Logout()
        {
            return View();
        }
    }
}