namespace Pocos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAllEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Broker_Stock_Ex",
                c => new
                    {
                        Broker_Id = c.Int(nullable: false),
                        Stock_Ex_Id = c.Int(nullable: false),
                        Stock_Exchange_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.Broker_Id, t.Stock_Ex_Id })
                .ForeignKey("dbo.Brokers", t => t.Broker_Id)
                .ForeignKey("dbo.Stock_Exchange", t => t.Stock_Exchange_Id)
                .Index(t => t.Broker_Id)
                .Index(t => t.Stock_Exchange_Id);
            
            CreateTable(
                "dbo.Brokers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 25),
                        LastName = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false, maxLength: 25),
                        Country = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stock_Exchange",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Symbol = c.String(),
                        Place_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Places", t => t.Place_Id)
                .Index(t => t.Place_Id);
            
        }
        
        public override void Down()
        {
            
        }
    }
}
