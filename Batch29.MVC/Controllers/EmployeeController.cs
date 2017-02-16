using Batch29.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            var db = new Users();
            if (ActionType.LoginST==myActionType)
            {
                bool isAuthorize = db.UserLogins
                .Where(x => x.UserName == data.UserId && x.Password == data.Password)
                .Any();

                if (isAuthorize)
                {
                    return View("Home");
                }
                else
                {
                    ViewBag.errorMsg = "Invalid User Name or Password";
                    return View("LoginST");
                }
            }
            else if(ActionType.Add == myActionType)
            {
                User user = new MVC.User();
                user.UserName = data.UserId;
                user.Password = data.Password;
                user.UserProfileId = 101;
                db.UserLogins.Add(user);
                db.SaveChanges();
            }
            else if (ActionType.Update == myActionType)
            {
                
                var result = db.UserLogins.SingleOrDefault(b => b.UserName == data.UserId);
                if (result != null)
                {
                    
                    result.UserName = data.UserId;
                    result.Password = data.Password;
                    db.Entry(result).State = EntityState.Modified;
                    db.SaveChanges();
                }
               // db.SaveChanges();

            }
            else if (ActionType.Delete == myActionType)
            {
                var result = db.UserLogins.SingleOrDefault(b => b.UserName == data.UserId);
                if (result != null)
                {
                    db.Entry(result).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            if (!ModelState.IsValid)
            {
                return View("LoginST",data);
            }



            return View();
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