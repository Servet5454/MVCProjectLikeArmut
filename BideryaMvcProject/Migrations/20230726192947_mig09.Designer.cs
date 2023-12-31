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
    [Migration("20230726192947_mig09")]
    partial class mig09
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.Property<string>("HizmetBolge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsTelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

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

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Ilanlar.AnkaraHizmetIlani", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HizmetAltKategori")
                        .HasColumnType("int");

                    b.Property<string>("HizmetBolge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HizmetTuru")
                        .HasColumnType("int");

                    b.Property<DateTime>("IlanTarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeklifSayisi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AnkaraHizmetIlanis");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Ilanlar.AnkaraIlanKoltukTemizlik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AnkaraHizmetIlaniId")
                        .HasColumnType("int");

                    b.Property<int>("CiftKisilikYatakSayisi")
                        .HasColumnType("int");

                    b.Property<int>("HizmetAltKategori")
                        .HasColumnType("int");

                    b.Property<string>("HizmetBolge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HizmetTuruId")
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

                    b.HasIndex("AnkaraHizmetIlaniId");

                    b.ToTable("AnkaraIlanTemizliks");
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
                            KayitTarihi = new DateTime(2023, 7, 26, 22, 29, 47, 388, DateTimeKind.Local).AddTicks(4034),
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
                            KayitTarihi = new DateTime(2023, 7, 26, 22, 29, 47, 388, DateTimeKind.Local).AddTicks(4037),
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

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.HizmetVerenAdres", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Hizmetler.HizmetVeren", "HizmetVeren")
                        .WithMany("HizmetverenAdres")
                        .HasForeignKey("HizmetVerenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HizmetVeren");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Ilanlar.AnkaraIlanKoltukTemizlik", b =>
                {
                    b.HasOne("BideryaMvcProject.DataBase.Entities.Ilanlar.AnkaraHizmetIlani", "AnkaraHizmetIlani")
                        .WithMany("AnkaraIlanTemizliks")
                        .HasForeignKey("AnkaraHizmetIlaniId");

                    b.Navigation("AnkaraHizmetIlani");
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

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Hizmetler.HizmetVeren", b =>
                {
                    b.Navigation("HizmetverenAdres");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Ilanlar.AnkaraHizmetIlani", b =>
                {
                    b.Navigation("AnkaraIlanTemizliks");
                });

            modelBuilder.Entity("BideryaMvcProject.DataBase.Entities.Kullanici.Kullanici", b =>
                {
                    b.Navigation("KullaniciAdress");
                });
#pragma warning restore 612, 618
        }
    }
}
