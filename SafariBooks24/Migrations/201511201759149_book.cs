namespace SafariBooks24.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class book : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        AuthorFName = c.String(nullable: false),
                        AuthorLName = c.String(nullable: false),
                        AvgRating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InStock = c.Boolean(nullable: false),
                        NumSold = c.Int(nullable: false),
                        PublicationDate = c.DateTime(nullable: false),
                        SellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Genre = c.String(nullable: false),
                        Supplier = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InventoryOnHand = c.Int(nullable: false),
                        ReorderPoint = c.Int(nullable: false),
                        NeedToOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
