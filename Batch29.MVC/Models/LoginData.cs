using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Batch29.MVC.Models
{
    public class LoginData
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        //[RegularExpression("@^ ((?=.*[a - z])(?=.*[A - Z])(?=.*\\d)).+$")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }

    public class DataAccessTier
    {
        public static List<LoginData> GetAllUsers()
        {
            List<LoginData> lst = new List<LoginData>();
            lst.Add(new Models.LoginData()
            {
                Password = "123456",
                UserId = "abc"
            });
            lst.Add(new Models.LoginData()
            {
                Password = "123456",
                UserId = "abc2"
            });

            lst.Add(new Models.LoginData()
            {
                Password = "123456",
                UserId = "abc3"
            });
            lst.Add(new Models.LoginData()
            {
                Password = "123456",
                UserId = "abc4"
            });
            return lst;
        }
    }
}