namespace testWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewFieldsOnContact : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Contacts");
            DropColumn("dbo.Contacts", "ContactId");
            AddColumn("dbo.Contacts", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Contacts", "FirstName", c => c.String());
            AddColumn("dbo.Contacts", "LastName", c => c.String());
            AddColumn("dbo.Contacts", "ManagerId", c => c.Int());
            AddColumn("dbo.Contacts", "ManagerName", c => c.String());
            AddColumn("dbo.Contacts", "Reports", c => c.Int());
            AddColumn("dbo.Contacts", "Title", c => c.String());
            AddColumn("dbo.Contacts", "Department", c => c.String());
            AddColumn("dbo.Contacts", "CellPhone", c => c.String());
            AddColumn("dbo.Contacts", "OfficePhone", c => c.String());
            AddColumn("dbo.Contacts", "Pic", c => c.String());
            AddColumn("dbo.Contacts", "TwitterId", c => c.String());
            AddColumn("dbo.Contacts", "Blog", c => c.String());
            AddPrimaryKey("dbo.Contacts", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "ContactId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Contacts");
            DropColumn("dbo.Contacts", "Blog");
            DropColumn("dbo.Contacts", "TwitterId");
            DropColumn("dbo.Contacts", "Pic");
            DropColumn("dbo.Contacts", "OfficePhone");
            DropColumn("dbo.Contacts", "CellPhone");
            DropColumn("dbo.Contacts", "Department");
            DropColumn("dbo.Contacts", "Title");
            DropColumn("dbo.Contacts", "Reports");
            DropColumn("dbo.Contacts", "ManagerName");
            DropColumn("dbo.Contacts", "ManagerId");
            DropColumn("dbo.Contacts", "LastName");
            DropColumn("dbo.Contacts", "FirstName");
            DropColumn("dbo.Contacts", "Id");
            AddPrimaryKey("dbo.Contacts", "ContactId");
        }
    }
}
