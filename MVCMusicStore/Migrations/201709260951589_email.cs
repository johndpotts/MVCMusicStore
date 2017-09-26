namespace MVCMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class email : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "ReviewerEmail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "ReviewerEmail", c => c.String());
        }
    }
}
