namespace PizzaGatResturant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyBirthday : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustomerBirthday", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustomerBirthday", c => c.DateTime(nullable: false));
        }
    }
}
