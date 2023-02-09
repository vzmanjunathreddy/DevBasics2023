namespace EFCodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "op.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        OrgId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("org.Orgnization", t => t.OrgId, cascadeDelete: true)
                .Index(t => t.OrgId);
            
            CreateTable(
                "op.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("op.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "org.Orgnization",
                c => new
                    {
                        OrgId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EstablishmentYear = c.DateTime(nullable: false),
                        TANNumber = c.String(),
                        ContactNumber = c.String(),
                    })
                .PrimaryKey(t => t.OrgId);
            
            CreateTable(
                "op.SupportEmployees",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Active = c.Byte(nullable: false),
                        ManagerId = c.Int(),
                        OrgId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpId)
                .ForeignKey("org.Orgnization", t => t.OrgId, cascadeDelete: true)
                .Index(t => t.OrgId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("op.SupportEmployees", "OrgId", "org.Orgnization");
            DropForeignKey("op.Customers", "OrgId", "org.Orgnization");
            DropForeignKey("op.Orders", "CustomerId", "op.Customers");
            DropIndex("op.SupportEmployees", new[] { "OrgId" });
            DropIndex("op.Orders", new[] { "CustomerId" });
            DropIndex("op.Customers", new[] { "OrgId" });
            DropTable("op.SupportEmployees");
            DropTable("org.Orgnization");
            DropTable("op.Orders");
            DropTable("op.Customers");
        }
    }
}
