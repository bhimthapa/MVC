using Batch29.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Batch29.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        //Strongly type view
        public ActionResult LoginST()
        {
            return View();
        }

        public String Test()
        {
            return "Hello MVC";
        }
        public ActionResult AuthenticateUser(string txtUserId,string txtPassword)
        {
            int x = 10;
            return View();
        }
        public ActionResult AuthenticateUserST(LoginData data)
        {
            if (!ModelState.IsValid)
            {
                return View("LoginST",data);
            }

            if(data.UserId=="abc" && data.Password=="123456")
            {
                return View("Home"); 
            }
            else
            {
                ViewBag.errorMsg = "Invalid User Name or Password";
                return View("LoginST");
            }
            
        }

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult DisplayUser()
        {
            return View(DataAccessTier.GetAllUsers());
        }


    }
}