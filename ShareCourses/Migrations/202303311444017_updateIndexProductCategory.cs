namespace ShareCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateIndexProductCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategory", "CreateBy", c => c.String());
            AddColumn("dbo.tb_ProductCategory", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_ProductCategory", "ModifiedrDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_ProductCategory", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_ProductCategory", "ModifiedBy");
            DropColumn("dbo.tb_ProductCategory", "ModifiedrDate");
            DropColumn("dbo.tb_ProductCategory", "CreatedDate");
            DropColumn("dbo.tb_ProductCategory", "CreateBy");
        }
    }
}
