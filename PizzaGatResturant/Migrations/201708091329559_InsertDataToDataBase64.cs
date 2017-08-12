namespace PizzaGatResturant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataToDataBase64 : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Customers(Id, Name, Address, City, Phone) Values(2, 'Yarden Maoz Sharabi', 'Zvi Tadmor 3', 'Holon', '0544997811')");
        }
        
        public override void Down()
        {
        }
    }
}
