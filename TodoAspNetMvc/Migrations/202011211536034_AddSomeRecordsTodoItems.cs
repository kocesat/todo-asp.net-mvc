namespace TodoAspNetMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeRecordsTodoItems : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TodoItems (ShortDescription, Description, CreationDate, Deadline, IsComplete) VALUES('Try Adding Record To Database1', 'Long Definition For It', 15/05/2010, 20/05/2010, 'False')");
        }

        public override void Down()
        {
        }
    }
}
