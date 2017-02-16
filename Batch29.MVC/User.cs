namespace Batch29.MVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int UserId { get; set; }

        public int UserProfileId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
