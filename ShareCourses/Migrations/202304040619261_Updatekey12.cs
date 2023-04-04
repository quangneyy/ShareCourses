namespace ShareCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatekey12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "TypePayment", c => c.Int(nullable: false));
            AddColumn("dbo.tb_Order", "Email", c => c.String());
            AddColumn("dbo.tb_Order", "CreateBy", c => c.String());
            AddColumn("dbo.tb_Order", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Order", "ModifiedrDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Order", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Order", "ModifiedBy");
            DropColumn("dbo.tb_Order", "ModifiedrDate");
            DropColumn("dbo.tb_Order", "CreatedDate");
            DropColumn("dbo.tb_Order", "CreateBy");
            DropColumn("dbo.tb_Order", "Email");
            DropColumn("dbo.tb_Order", "TypePayment");
        }
    }
}
