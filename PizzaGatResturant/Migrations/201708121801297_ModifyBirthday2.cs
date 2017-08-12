namespace PizzaGatResturant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyBirthday2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerBirthday", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerBirthday");
        }
    }
}
