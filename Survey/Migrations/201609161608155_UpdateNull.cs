namespace Survey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNull : DbMigration
    {
        public override void Up()
        {
            Sql("Update Options Set OptionThreeValue=0 Where Id=1 ");
            Sql("Update Options Set OptionFourValue=0 Where Id=1 ");
            Sql("Update Options Set OptionThreeValue=0 Where Id=2 ");
            Sql("Update Options Set OptionFourValue=0 Where Id=2 ");
            AlterColumn("dbo.Options", "OptionThreeValue", c => c.Int(nullable: false));
            AlterColumn("dbo.Options", "OptionFourValue", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Options", "OptionFourValue", c => c.Int());
            AlterColumn("dbo.Options", "OptionThreeValue", c => c.Int());
        }
    }
}
