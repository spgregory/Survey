namespace Survey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNullColumns : DbMigration
    {
        public override void Up()
        {
            Sql("Update Options Set OptionThreeValue=0 Where Id=1 ");
            Sql("Update Options Set OptionFourValue=0 Where Id=1 ");
            Sql("Update Options Set OptionThreeValue=0 Where Id=2 ");
            Sql("Update Options Set OptionFourValue=0 Where Id=2 ");


        }

        public override void Down()
        {
        }
    }
}
