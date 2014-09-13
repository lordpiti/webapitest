namespace testWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewFieldsOnContact : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Contacts");

            CreateTable(
                "dbo.Contacts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Address = c.String(),
                    City = c.String(),
                    State = c.String(),
                    Zip = c.String(),
                    Email = c.String(),
                    Twitter = c.String(),
                    Self = c.String(),
                })
                .PrimaryKey(t => t.Id);

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

        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");

            CreateTable(
                "dbo.Contacts",
                c => new
                {
                    ContactId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Address = c.String(),
                    City = c.String(),
                    State = c.String(),
                    Zip = c.String(),
                    Email = c.String(),
                    Twitter = c.String(),
                    Self = c.String(),
                })
                .PrimaryKey(t => t.ContactId);
        }
    }
}
