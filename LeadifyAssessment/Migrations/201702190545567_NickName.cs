namespace LeadifyAssessment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NickName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "NickName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "NickName");
        }
    }
}
