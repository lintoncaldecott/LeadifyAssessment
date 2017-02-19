namespace LeadifyAssessment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeNickName : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contact", "NickName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contact", "NickName", c => c.String());
        }
    }
}
