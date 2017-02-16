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
        public ActionResult AuthenticateUserST(LoginData data, ActionType myActionType)
        {
            if(ActionType.LoginST==myActionType)
            {

            }
            else if(ActionType.Add == myActionType)
            {

            }
            else if (ActionType.Update == myActionType)
            {

            }
            else if (ActionType.Delete == myActionType)
            {

            }
            if (!ModelState.IsValid)
            {
                return View("LoginST",data);
            }

            var db = new Users();
            bool isAuthorize = db.UserLogins
                .Where(x => x.UserName == data.UserId && x.Password == data.Password)
                .Any();

            if(isAuthorize)
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
    public enum ActionType
    {
        Add,
        Update,
        Delete,
        LoginST

    }
}