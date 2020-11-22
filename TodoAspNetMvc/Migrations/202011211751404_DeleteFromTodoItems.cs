namespace TodoAspNetMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteFromTodoItems : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM TodoItems WHERE Id BETWEEN 11 AND 10000");

        }

        public override void Down()
        {
        }
    }
}
