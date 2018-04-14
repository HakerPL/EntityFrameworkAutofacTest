namespace EntityMySQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNam2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Name2", c => c.String(maxLength: 20, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Name2");
        }
    }
}
