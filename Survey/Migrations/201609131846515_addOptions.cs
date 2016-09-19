namespace Survey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addOptions : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT dbo.Options ON");
            Sql("INSERT INTO Options(Id,OptionOne,OptionTwo,OptionThree,OptionFour,OptionOneValue,OptionTwoValue,OptionThreeValue,OptionFourValue)Values(1,'Fall','Winter','Spring','Summer',0,0,0,0)");
            Sql("INSERT INTO Options(Id,OptionOne,OptionTwo,OptionThree,OptionFour,OptionOneValue,OptionTwoValue,OptionThreeValue,OptionFourValue)Values(2,'Chicago','LA','New York','Houston',0,0,0,0)");


        }

        public override void Down()
        {
        }
    }
}
