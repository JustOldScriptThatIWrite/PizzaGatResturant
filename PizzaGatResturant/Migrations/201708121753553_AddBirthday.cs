namespace PizzaGatResturant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerBirthday", c => c.DateTime(nullable: false));
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerBirthday");
        }
    }
}
