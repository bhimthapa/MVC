namespace MVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.LoginUsers",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 200),
                        Password = c.String(),

                    });
                   
                    

        }

        public override void Down()
        {
        }
    }
}
