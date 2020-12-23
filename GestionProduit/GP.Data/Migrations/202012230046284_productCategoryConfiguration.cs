namespace GP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productCategoryConfiguration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Products", newName: "les_produits");
            RenameColumn(table: "dbo.les_produits", name: "Name", newName: "nomProduit");
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.les_produits", "nomProduit", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.les_produits", "nomProduit", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Categories", "Name", c => c.String());
            RenameColumn(table: "dbo.les_produits", name: "nomProduit", newName: "Name");
            RenameTable(name: "dbo.les_produits", newName: "Products");
        }
    }
}
