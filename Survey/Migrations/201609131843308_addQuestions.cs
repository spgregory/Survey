namespace Survey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addQuestions : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT dbo.Questions ON");
            Sql("INSERT INTO Questions(Id,QuestionText,Option_Name)Values(1,'Favorite season of the year?','Fall')");
            Sql("INSERT INTO Questions(Id,QuestionText,Option_Name)Values(2,'Closest big city near you?','Chicago')");

        }

        public override void Down()
        {
        }
    }
}
