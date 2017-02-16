using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Data
{
   public class LoginDBContext : DbContext
    {
        public LoginDBContext():base("MVCConn") 
        {

        }
     public  DbSet<Login> LoginUsers { get; set;}
    }
}
