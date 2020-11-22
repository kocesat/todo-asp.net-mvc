namespace TodoAspNetMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTodoITems : DbMigration
    {
        public override void Up()
        {
            for (int i = 6; i < 10_000; i++)
            {
                Sql($"INSERT INTO TodoItems (ShortDescription, Description, CreationDate, Deadline, IsComplete) VALUES('Try Adding Record To Database{i}', 'Long Definition For Item {i}', 15/05/2010, 20/05/2010, 'False')");
            }
        }
        
        public override void Down()
        {

        }
    }
}
