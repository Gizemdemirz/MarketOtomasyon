namespace MarketOtamasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CokSatanlar : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
           "dbo.CokSatanlar",
           p => new
           {

           },
           body:


           @" Select UrunAdi, SUM(UrunMiktarı) as UrunMiktarı from Satis Group By UrunAdi order by UrunMiktarı desc"
       );
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.CokSatanlar");
        }
    }
}
