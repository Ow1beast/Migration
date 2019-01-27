namespace Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Teams", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "City");
            DropColumn("dbo.Players", "Age");
        }
    }
}
