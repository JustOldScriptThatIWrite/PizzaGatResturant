namespace PizzaGatResturant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondChange : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Customers (Id,Name,Address,City,Phone) Values (1,'Oren Maoz Sharabi','Zvi Tadmor 3','Holon','0524525454')");
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Pizzas", "Customers_Id", c => c.Byte());
            CreateIndex("dbo.Pizzas", "Customers_Id");
            AddForeignKey("dbo.Pizzas", "Customers_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pizzas", "Customers_Id", "dbo.Customers");
            DropIndex("dbo.Pizzas", new[] { "Customers_Id" });
            DropColumn("dbo.Pizzas", "Customers_Id");
            DropTable("dbo.Customers");
        }
    }
}
