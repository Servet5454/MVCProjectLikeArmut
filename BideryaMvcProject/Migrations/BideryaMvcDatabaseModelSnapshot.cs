﻿// <auto-generated />
using System;
using BideryaMvcProject.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    [DbContext(typeof(BideryaMvcDatabase))]
    partial class BideryaMvcDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.CamBalkon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BalkonCephe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BalkonCevresi")
                        .HasColumnType("int");

                    b.Property<int>("BalkonYukseklik")
                        .HasColumnType("int");

                    b.Property<string>("CamBalkonTuru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CamRengi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CamBalkons");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.EvTadilat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banyo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoyaBadana")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CamBalkon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diger")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EvinDurumu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FayansDoseme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KapıPencere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MalzemeKalitesi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MetreKare")
                        .HasColumnType("int");

                    b.Property<string>("Mutfak")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParkeLaminant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TadilatIsTuru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TadilatOdaları")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TadilatTipi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EvTadilats");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.Mantolama", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BalkonTipi")
                        .HasColumnType("int");

                    b.Property<int>("BinaCepheUzunluk")
                        .HasColumnType("int");

                    b.Property<int>("BinaKatSayisi")
                        .HasColumnType("int");

                    b.Property<int>("CepheSayisi")
                        .HasColumnType("int");

                    b.Property<int>("KisaCepheUzunluk")
                        .HasColumnType("int");

                    b.Property<string>("MarkaTercih")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ozellikler")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mantolamas");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.MutfakDolabiYapimi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsTuru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MalzemeTercihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("ToplamDolapUzunluk")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("MutfakDolabiYapimis");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.TadilatDekorasyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HizmetTuruId")
                        .HasColumnType("int");

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TadilatDekorasyons");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.AracYikama", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DigerYerler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KoltukSayisi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AracYikamas");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.EvTemizlik", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BalkonSayisi")
                        .HasColumnType("int");

                    b.Property<int>("BanyoSayisi")
                        .HasColumnType("int");

                    b.Property<float>("CalismaSuresi")
                        .HasColumnType("real");

                    b.Property<string>("HayvanVarmi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OdaSayisi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EvTemizliks");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.Ilaclama", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasereTipi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MekanTipi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Metrekare")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ilaclamas");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.KoltukTemizlik", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CiftKisilikYatakSayisi")
                        .HasColumnType("int");

                    b.Property<int>("IkiliKoltukSayisi")
                        .HasColumnType("int");

                    b.Property<int>("LKoltukSayisi")
                        .HasColumnType("int");

                    b.Property<int>("MinderSayisi")
                        .HasColumnType("int");

                    b.Property<int>("SandalyeSayisi")
                        .HasColumnType("int");

                    b.Property<int>("TekliKoltukSayisi")
                        .HasColumnType("int");

                    b.Property<int>("TekliYatakSayisi")
                        .HasColumnType("int");

                    b.Property<int>("UcluKoltukSayisi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KoltukTemizliks");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.Temizlik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("BanyoSayisi")
                        .HasColumnType("smallint");

                    b.Property<float?>("CalismaSuresi")
                        .HasColumnType("real");

                    b.Property<bool>("EvBosmu")
                        .HasColumnType("bit");

                    b.Property<bool>("HayvanVarmi")
                        .HasColumnType("bit");

                    b.Property<string>("HizmetServis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HizmetVerenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Temizliks");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanici.HizmetVeren", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmaIsmi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HizmetBolge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HizmetTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HizmetTuruId")
                        .HasColumnType("int");

                    b.Property<string>("IsTelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sifre1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SilinmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VergiNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HizmetVerens");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanici.HizmetVerenAdres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdresAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresGenel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adresbasligi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HizmetVerenId")
                        .HasColumnType("int");

                    b.Property<string>("Il")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mahalle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HizmetVerenId");

                    b.ToTable("HizmetVerenAdres");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanici.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sifre1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Sifre2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kullanicis");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Ahmet",
                            Email = "ahmet.yilmaz@gmail.com",
                            KayitTarihi = new DateTime(2023, 7, 24, 14, 5, 39, 45, DateTimeKind.Local).AddTicks(6026),
                            Sifre1 = "123456",
                            Sifre2 = "123456",
                            Soyad = "Yılmaz",
                            TelNo = "5551112233"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Ayşe",
                            Email = "ayse.kaya@gmail.com",
                            KayitTarihi = new DateTime(2023, 7, 24, 14, 5, 39, 45, DateTimeKind.Local).AddTicks(6030),
                            Sifre1 = "678900",
                            Sifre2 = "678900",
                            Soyad = "Kaya",
                            TelNo = "5554445566"
                        });
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanici.KullaniciAdres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdresAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresGenel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adresbasligi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Il")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("Mahalle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("KullaniciAdress");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdresGenel = "Yenikent Ankara",
                            Adresbasligi = "Ev Adresi",
                            Il = "Ankara",
                            Ilce = "Sincan",
                            KullaniciId = 1,
                            Mahalle = "Yeniken"
                        },
                        new
                        {
                            Id = 2,
                            AdresGenel = "Yenikent Ankara",
                            Adresbasligi = "İş Adresi",
                            Il = "Ankara",
                            Ilce = "Sincan",
                            KullaniciId = 1,
                            Mahalle = "Yeniken"
                        },
                        new
                        {
                            Id = 3,
                            AdresGenel = "Yenikent Ankara",
                            Adresbasligi = "Dükkan Adresi",
                            Il = "Ankara",
                            Ilce = "Sincan",
                            KullaniciId = 1,
                            Mahalle = "Yeniken"
                        },
                        new
                        {
                            Id = 4,
                            AdresGenel = "Yenikent Ankara",
                            Adresbasligi = "Ev Adresi",
                            Il = "Ankara",
                            Ilce = "Sincan",
                            KullaniciId = 2,
                            Mahalle = "Yeniken"
                        },
                        new
                        {
                            Id = 5,
                            AdresGenel = "Yenikent Ankara",
                            Adresbasligi = "İş Adresi",
                            Il = "Ankara",
                            Ilce = "Sincan",
                            KullaniciId = 2,
                            Mahalle = "Yeniken"
                        },
                        new
                        {
                            Id = 6,
                            AdresGenel = "Yenikent Ankara",
                            Adresbasligi = "Dükkan Adresi",
                            Il = "Ankara",
                            Ilce = "Sincan",
                            KullaniciId = 2,
                            Mahalle = "Yeniken"
                        });
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanici.HizmetVerenAdres", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Kullanici.HizmetVeren", "HizmetVeren")
                        .WithMany("HizmetverenAdres")
                        .HasForeignKey("HizmetVerenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HizmetVeren");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanici.KullaniciAdres", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Kullanici.Kullanici", "Kullanici")
                        .WithMany("KullaniciAdress")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanici.HizmetVeren", b =>
                {
                    b.Navigation("HizmetverenAdres");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanici.Kullanici", b =>
                {
                    b.Navigation("KullaniciAdress");
                });
#pragma warning restore 612, 618
        }
    }
}
