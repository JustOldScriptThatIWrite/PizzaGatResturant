namespace PizzaGatResturant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyBirthday1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "CustomerBirthday");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerBirthday", c => c.DateTime());
        }
    }
}
