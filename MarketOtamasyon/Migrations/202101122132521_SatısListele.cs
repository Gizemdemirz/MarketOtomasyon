namespace MarketOtamasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SatısListele : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
            "dbo.MarketOtomasyon",
            p => new
            {

            },
            body:
                @"Select * from Satis"
        );
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.MarketOtomasyon");
        }
    }
}
