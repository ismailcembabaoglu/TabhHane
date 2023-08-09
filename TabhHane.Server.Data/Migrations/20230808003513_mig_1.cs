using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TabhHane.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bankalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HesapKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapIsmi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bankasi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Sube = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    YetkiliAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    YetkiliTelefonu = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bankalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cariler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durumu = table.Column<bool>(type: "bit", nullable: false),
                    CariTuru = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CariKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    CariAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    YetkiliKisi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaturaUnvani = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CepTelefonu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Web = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Il = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Semt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CariGrubu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CariAltGrubu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OzelKod1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OzelKod2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OzelKod3 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OzelKod4 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VergiNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IskontoOrani = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    RiskLimiti = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    AlisOzelFiyati = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    SatisOzelFiyati = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cariler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Depolar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    DepoAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    YetkiliKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    YetkiliAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Il = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Semt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depolar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HizliSatislar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barkod = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UrunAdi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    GrupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizliSatislar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HizliSatislarGruplari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizliSatislarGruplari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Indirimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durumu = table.Column<bool>(type: "bit", nullable: false),
                    StokKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Barkod = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StokAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IndirimTuru = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IndirimOrani = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indirimler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kasalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KasaKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    KasaAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    YetkiliKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    YetkiliAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kasalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kodlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tablo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    OnEki = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    SonDeger = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kodlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Gorevi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    HatirlatmaSorusu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cevap = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SonGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OdemeTurleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OdemeTuruKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    OdemeTuruAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdemeTurleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonelHareketleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FisKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Unvani = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PersonelKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    PersonelAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TcKimlikNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Donemi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrimOrani = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    ToplamSatis = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    AylikMaasi = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelHareketleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calisiyor = table.Column<bool>(type: "bit", nullable: false),
                    Unvani = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PersonelKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    PersonelAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TcKimlikNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    IseGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IstenCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VergiDairesi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VergiNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CepTelefonu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Web = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Il = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Semt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrimOrani = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    AylikMaasi = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SirketBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    SirketKisaAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SirketUnvani = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Ulkesi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Ili = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Ilcesi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Semt = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VergiNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SirketTelNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Web = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YetkiliKisi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SirketBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stoklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durumu = table.Column<bool>(type: "bit", nullable: false),
                    StokKodu = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    StokAdi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Barkod = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BarkodTuru = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Birimi = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    StokGrubu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StokAltGrubu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Modeli = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OzelKod1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OzelKod2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OzelKod3 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OzelKod4 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GarantiSüresi = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UreticiKodu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AlisKdv = table.Column<int>(type: "int", nullable: false),
                    SatisKdv = table.Column<int>(type: "int", nullable: false),
                    AlisFiyati1 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    AlisFiyati2 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    AlisFiyati3 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    SatisFiyati1 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    SatisFiyati2 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    SatisFiyati3 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    MinStokMiktari = table.Column<decimal>(type: "decimal(12,3)", precision: 12, scale: 3, nullable: true),
                    MaxStokMiktari = table.Column<decimal>(type: "decimal(12,3)", precision: 12, scale: 3, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoklar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tanimlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Turu = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Tanimi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanimlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankaHareketleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FisKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Hareket = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BankaId = table.Column<int>(type: "int", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tutar = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankaHareketleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankaHareketleri_Bankalar_BankaId",
                        column: x => x.BankaId,
                        principalTable: "Bankalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankaHareketleri_Cariler_CariId",
                        column: x => x.CariId,
                        principalTable: "Cariler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciRolleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RootId = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FormAdi = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    KontrolAdi = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Yetki = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciRolleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciRolleri_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KasaHareketleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FisKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Hareket = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    KasaId = table.Column<int>(type: "int", nullable: false),
                    OdemeTuruId = table.Column<int>(type: "int", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tutar = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KasaHareketleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KasaHareketleri_Cariler_CariId",
                        column: x => x.CariId,
                        principalTable: "Cariler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KasaHareketleri_Kasalar_KasaId",
                        column: x => x.KasaId,
                        principalTable: "Kasalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KasaHareketleri_OdemeTurleri_OdemeTuruId",
                        column: x => x.OdemeTuruId,
                        principalTable: "OdemeTurleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fisler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FisKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    FisTuru = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: false),
                    BelgeNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlasiyerId = table.Column<int>(type: "int", nullable: true),
                    IskontoOrani = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    IskontoTutar = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Alacak = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Borc = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    ToplamTutar = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FisBaglantiKodu = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    DepoIrsaliye = table.Column<bool>(type: "bit", nullable: false),
                    DepoId = table.Column<int>(type: "int", nullable: false),
                    BankaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fisler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fisler_Bankalar_BankaId",
                        column: x => x.BankaId,
                        principalTable: "Bankalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fisler_Cariler_CariId",
                        column: x => x.CariId,
                        principalTable: "Cariler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fisler_Depolar_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depolar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fisler_Personeller_PlasiyerId",
                        column: x => x.PlasiyerId,
                        principalTable: "Personeller",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StokHareketleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FisKodu = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    FisBaglantiKodu = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Hareket = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StokId = table.Column<int>(type: "int", nullable: false),
                    Miktar = table.Column<decimal>(type: "decimal(12,3)", precision: 12, scale: 3, nullable: true),
                    Kdv = table.Column<int>(type: "int", nullable: false),
                    BirimFiyati = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    AlisFiyati = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    AlisFiyati2 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    AlisFiyati3 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    IndirimOrani = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    ToplamTutar = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    MevcutStok = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    SayimMiktari = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    DepoId = table.Column<int>(type: "int", nullable: false),
                    SeriNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Siparis = table.Column<bool>(type: "bit", nullable: false),
                    Irsaliye = table.Column<bool>(type: "bit", nullable: false),
                    Teklif = table.Column<bool>(type: "bit", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokHareketleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StokHareketleri_Depolar_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depolar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StokHareketleri_Stoklar_StokId",
                        column: x => x.StokId,
                        principalTable: "Stoklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankaHareketleri_BankaId",
                table: "BankaHareketleri",
                column: "BankaId");

            migrationBuilder.CreateIndex(
                name: "IX_BankaHareketleri_CariId",
                table: "BankaHareketleri",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Fisler_BankaId",
                table: "Fisler",
                column: "BankaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fisler_CariId",
                table: "Fisler",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Fisler_DepoId",
                table: "Fisler",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fisler_PlasiyerId",
                table: "Fisler",
                column: "PlasiyerId");

            migrationBuilder.CreateIndex(
                name: "IX_KasaHareketleri_CariId",
                table: "KasaHareketleri",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_KasaHareketleri_KasaId",
                table: "KasaHareketleri",
                column: "KasaId");

            migrationBuilder.CreateIndex(
                name: "IX_KasaHareketleri_OdemeTuruId",
                table: "KasaHareketleri",
                column: "OdemeTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciRolleri_KullaniciId",
                table: "KullaniciRolleri",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_StokHareketleri_DepoId",
                table: "StokHareketleri",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_StokHareketleri_StokId",
                table: "StokHareketleri",
                column: "StokId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankaHareketleri");

            migrationBuilder.DropTable(
                name: "Fisler");

            migrationBuilder.DropTable(
                name: "HizliSatislar");

            migrationBuilder.DropTable(
                name: "HizliSatislarGruplari");

            migrationBuilder.DropTable(
                name: "Indirimler");

            migrationBuilder.DropTable(
                name: "KasaHareketleri");

            migrationBuilder.DropTable(
                name: "Kodlar");

            migrationBuilder.DropTable(
                name: "KullaniciRolleri");

            migrationBuilder.DropTable(
                name: "PersonelHareketleri");

            migrationBuilder.DropTable(
                name: "SirketBilgileri");

            migrationBuilder.DropTable(
                name: "StokHareketleri");

            migrationBuilder.DropTable(
                name: "Tanimlar");

            migrationBuilder.DropTable(
                name: "Bankalar");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Cariler");

            migrationBuilder.DropTable(
                name: "Kasalar");

            migrationBuilder.DropTable(
                name: "OdemeTurleri");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Depolar");

            migrationBuilder.DropTable(
                name: "Stoklar");
        }
    }
}
