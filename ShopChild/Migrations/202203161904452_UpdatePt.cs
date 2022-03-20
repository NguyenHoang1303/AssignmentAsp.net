namespace ShopChild.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePt : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Product", name: "Category_Id", newName: "CategoryId");
            RenameIndex(table: "dbo.Product", name: "IX_Category_Id", newName: "IX_CategoryId");
            DropColumn("dbo.Product", "CatrgoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "CatrgoryId", c => c.String());
            RenameIndex(table: "dbo.Product", name: "IX_CategoryId", newName: "IX_Category_Id");
            RenameColumn(table: "dbo.Product", name: "CategoryId", newName: "Category_Id");
        }
    }
}
