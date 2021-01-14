namespace MarketOtamasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BorcRaporu : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
            "dbo.BorcRaporu",
            p => new
            {

            },
            body:


            @" Select * from Musteris join Satis on Musteris.MusteriId = Satis.Musteri_MusteriId where Musteris.borc != 0"
        );
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.BorcRaporu");
        }
    }
}
