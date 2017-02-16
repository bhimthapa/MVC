namespace Batch29.MVC
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Users : DbContext
    {
        public Users()
            : base("name=Users")
        {
        }

        public virtual DbSet<User> UserLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
