namespace PositiveWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nume = c.String(),
                        Prenume = c.String(),
                        Oras = c.String(),
                        Judet = c.String(),
                        Email = c.String(),
                        Institution = c.String(),
                        Description = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        PictureUrl = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                        Password = c.String(),
                        AuthState = c.Boolean(nullable: false),
                        Ranking = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
