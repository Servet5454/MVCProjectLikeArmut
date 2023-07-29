﻿// <auto-generated />
using System;
using BideryaMvcProject.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BideryaMvcProject.Migrations
{
    [DbContext(typeof(BideryaMvcDatabase))]
    [Migration("20230729083352_mig44")]
    partial class mig44
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.HizmetAltKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AracYikamaIslemi")
                        .HasColumnType("bit");

                    b.Property<bool>("CamBalkon")
                        .HasColumnType("bit");

                    b.Property<bool>("EvTadilat")
                        .HasColumnType("bit");

                    b.Property<bool>("EvTemizlikIslemi")
                        .HasColumnType("bit");

                    b.Property<int>("HizmetKategoriId")
                        .HasColumnType("int");

                    b.Property<int>("HizmetVerenId")
                        .HasColumnType("int");

                    b.Property<int>("HizmetVerenName")
                        .HasColumnType("int");

                    b.Property<bool>("IlaclamaIslemi")
                        .HasColumnType("bit");

                    b.Property<bool>("KoltukTemizlikIslemi")
                        .HasColumnType("bit");

                    b.Property<bool>("Mantolama")
                        .HasColumnType("bit");

                    b.Property<bool>("MutfakDolabiYapimi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("HizmetVerenId")
                        .IsUnique();

                    b.ToTable("HizmetAltKategoris");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.HizmetVeren", b =>
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

                    b.Property<int>("HizmetKategoriId")
                        .HasColumnType("int");

                    b.Property<string>("IsTelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("VergiNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HizmetVerens");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.HizmetVerenAdres", b =>
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

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.CamBalkon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.Property<int>("IlanId")
                        .HasColumnType("int");

                    b.Property<int>("TadilatDekorasyonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IlanId")
                        .IsUnique();

                    b.ToTable("CamBalkons");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.EvTadilat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.Property<int>("IlanId")
                        .HasColumnType("int");

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

                    b.HasIndex("IlanId")
                        .IsUnique();

                    b.ToTable("EvTadilats");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.Mantolama", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.Property<int>("IlanId")
                        .HasColumnType("int");

                    b.Property<int>("KisaCepheUzunluk")
                        .HasColumnType("int");

                    b.Property<string>("MarkaTercih")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ozellikler")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IlanId")
                        .IsUnique();

                    b.ToTable("Mantolamas");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.MutfakDolabiYapimi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IlanId")
                        .HasColumnType("int");

                    b.Property<string>("IsTuru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MalzemeTercihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("ToplamDolapUzunluk")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("IlanId")
                        .IsUnique();

                    b.ToTable("MutfakDolabiYapimis");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.TadilatDekorasyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HizmetKategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TadilatDekorasyons");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.AracYikama", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DigerYerler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IlanId")
                        .HasColumnType("int");

                    b.Property<int>("KoltukSayisi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IlanId")
                        .IsUnique();

                    b.ToTable("AracYikamas");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.EvTemizlik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BalkonSayisi")
                        .HasColumnType("int");

                    b.Property<int>("BanyoSayisi")
                        .HasColumnType("int");

                    b.Property<float>("CalismaSuresi")
                        .HasColumnType("real");

                    b.Property<bool>("HayvanVarmi")
                        .HasColumnType("bit");

                    b.Property<int>("IlanId")
                        .HasColumnType("int");

                    b.Property<int>("OdaSayisi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IlanId")
                        .IsUnique();

                    b.ToTable("EvTemizliks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aciklama = "Temizlenecek",
                            BalkonSayisi = 1,
                            BanyoSayisi = 1,
                            CalismaSuresi = 3f,
                            HayvanVarmi = false,
                            IlanId = 1,
                            OdaSayisi = 1
                        });
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.Ilaclama", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HasereTipi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IlanId")
                        .HasColumnType("int");

                    b.Property<string>("MekanTipi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Metrekare")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IlanId")
                        .IsUnique();

                    b.ToTable("Ilaclamas");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.KoltukTemizlik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CiftKisilikYatakSayisi")
                        .HasColumnType("int");

                    b.Property<int>("IkiliKoltukSayisi")
                        .HasColumnType("int");

                    b.Property<int>("IlanId")
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

                    b.Property<int>("TeklifSayisi")
                        .HasColumnType("int");

                    b.Property<int>("UcluKoltukSayisi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IlanId")
                        .IsUnique();

                    b.ToTable("KoltukTemizliks");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.TemizlikAna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AltKategoriId")
                        .HasColumnType("int");

                    b.Property<short?>("BanyoSayisi")
                        .HasColumnType("smallint");

                    b.Property<float?>("CalismaSuresi")
                        .HasColumnType("real");

                    b.Property<bool>("EvBosmu")
                        .HasColumnType("bit");

                    b.Property<bool>("HayvanVarmi")
                        .HasColumnType("bit");

                    b.Property<int>("HizmetKategoriId")
                        .HasColumnType("int");

                    b.Property<string>("HizmetServis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TemizlikAnas");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Ilanlar.Ilan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdresDetay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Il")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IlanAltKategoriId")
                        .HasColumnType("int");

                    b.Property<int>("IlanKategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Ilans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdresDetay = "Ayaş Merkez",
                            Il = "Ankara",
                            IlanAltKategoriId = 1,
                            IlanKategoriId = 1,
                            Ilce = "Yenikent",
                            KullaniciId = 1
                        });
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanicilar.Kullanici", b =>
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
                            KayitTarihi = new DateTime(2023, 7, 29, 11, 33, 51, 885, DateTimeKind.Local).AddTicks(6313),
                            Sifre1 = "3A987843C71CDC036B1477D929084804",
                            Sifre2 = "3A987843C71CDC036B1477D929084804",
                            Soyad = "Yılmaz",
                            TelNo = "05555555555"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Ayşe",
                            Email = "ayse@gmail.com",
                            KayitTarihi = new DateTime(2023, 7, 29, 11, 33, 51, 885, DateTimeKind.Local).AddTicks(6318),
                            Sifre1 = "3A987843C71CDC036B1477D929084804",
                            Sifre2 = "3A987843C71CDC036B1477D929084804",
                            Soyad = "Kaya",
                            TelNo = "05555555555"
                        });
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanicilar.KullaniciAdres", b =>
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

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.HizmetAltKategori", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Hizmetler.HizmetVeren", "HizmetVeren")
                        .WithOne("HizmetAltKategori")
                        .HasForeignKey("BideryaMvcProject.DataBase.Entities.Hizmetler.HizmetAltKategori", "HizmetVerenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HizmetVeren");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.HizmetVerenAdres", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Hizmetler.HizmetVeren", "HizmetVeren")
                        .WithMany("HizmetverenAdress")
                        .HasForeignKey("HizmetVerenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HizmetVeren");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.CamBalkon", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Ilanlar.Ilan", "Ilan")
                        .WithOne("CamBalkon")
                        .HasForeignKey("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.CamBalkon", "IlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.EvTadilat", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Ilanlar.Ilan", "Ilan")
                        .WithOne("EvTadilat")
                        .HasForeignKey("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.EvTadilat", "IlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.Mantolama", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Ilanlar.Ilan", "Ilan")
                        .WithOne("Mantolama")
                        .HasForeignKey("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.Mantolama", "IlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.MutfakDolabiYapimi", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Ilanlar.Ilan", "Ilan")
                        .WithOne("MutfakDolabiYapimi")
                        .HasForeignKey("BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon.MutfakDolabiYapimi", "IlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.AracYikama", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Ilanlar.Ilan", "Ilan")
                        .WithOne("AracYikama")
                        .HasForeignKey("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.AracYikama", "IlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.EvTemizlik", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Ilanlar.Ilan", "Ilan")
                        .WithOne("EvTemizlik")
                        .HasForeignKey("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.EvTemizlik", "IlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.Ilaclama", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Ilanlar.Ilan", "Ilan")
                        .WithOne("Ilaclama")
                        .HasForeignKey("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.Ilaclama", "IlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.KoltukTemizlik", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Ilanlar.Ilan", "Ilan")
                        .WithOne("KoltukTemizlik")
                        .HasForeignKey("BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik.KoltukTemizlik", "IlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilan");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Ilanlar.Ilan", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Kullanicilar.Kullanici", "Kullanici")
                        .WithMany("Ilans")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanicilar.KullaniciAdres", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Kullanicilar.Kullanici", "Kullanici")
                        .WithMany("KullaniciAdress")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.HizmetVeren", b =>
                {
                    b.Navigation("HizmetAltKategori");

                    b.Navigation("HizmetverenAdress");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Ilanlar.Ilan", b =>
                {
                    b.Navigation("AracYikama");

                    b.Navigation("CamBalkon");

                    b.Navigation("EvTadilat");

                    b.Navigation("EvTemizlik");

                    b.Navigation("Ilaclama");

                    b.Navigation("KoltukTemizlik");

                    b.Navigation("Mantolama");

                    b.Navigation("MutfakDolabiYapimi");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanicilar.Kullanici", b =>
                {
                    b.Navigation("Ilans");

                    b.Navigation("KullaniciAdress");
                });
#pragma warning restore 612, 618
        }
    }
}
