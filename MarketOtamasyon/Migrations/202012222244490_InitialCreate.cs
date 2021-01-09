namespace MarketOtamasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        MusteriAdi = c.String(),
                        MusteriSoyadi = c.String(),
                        telNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MusteriId);
            
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        barkodNo = c.Int(nullable: false),
                        kategori = c.Int(nullable: false),
                        marka = c.Int(nullable: false),
                        UrunAdi = c.Int(nullable: false),
                        miktar = c.Int(nullable: false),
                        alisFiyati = c.Int(nullable: false),
                        satisFiyati = c.Int(nullable: false),
                        tarih = c.Int(nullable: false),
                        Musteri_MusteriId = c.Int(),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Musteris", t => t.Musteri_MusteriId)
                .Index(t => t.Musteri_MusteriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uruns", "Musteri_MusteriId", "dbo.Musteris");
            DropIndex("dbo.Uruns", new[] { "Musteri_MusteriId" });
            DropTable("dbo.Uruns");
            DropTable("dbo.Musteris");
        }
    }
}
