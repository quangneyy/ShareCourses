namespace ShareCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductVirtualKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "CreateBy", c => c.String());
            AddColumn("dbo.tb_Product", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Product", "ModifiedrDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Product", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "ModifiedBy");
            DropColumn("dbo.tb_Product", "ModifiedrDate");
            DropColumn("dbo.tb_Product", "CreatedDate");
            DropColumn("dbo.tb_Product", "CreateBy");
        }
    }
}
