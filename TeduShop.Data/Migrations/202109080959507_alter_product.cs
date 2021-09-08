namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alter_product : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Tags", c => c.String());
            AddColumn("dbo.Product", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "OriginalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "OriginalPrice");
            DropColumn("dbo.Product", "Quantity");
            DropColumn("dbo.Product", "Tags");
        }
    }
}
