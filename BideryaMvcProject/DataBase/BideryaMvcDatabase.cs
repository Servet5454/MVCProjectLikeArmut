﻿using BideryaMvcProject.DataBase.Entities.Hizmetler;
using BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon;
using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;
using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.DataBase.Entities.Kullanicilar;
using Microsoft.EntityFrameworkCore;

namespace BideryaMvcProject.DataBase
{
    public class BideryaMvcDatabase : DbContext
    {

        #region Kullanıcı HizmetVeren DbSetleri
        public DbSet<Kullanici>? Kullanicis { get; set; }
        public DbSet<KullaniciAdres>? KullaniciAdress { get; set; }
        public DbSet<HizmetVeren>? HizmetVerens { get; set; }
        public DbSet<HizmetVerenAdres>? HizmetVerenAdres { get; set; }
        //public DbSet<HizmetKategori>? HizmetKategoris { get; set; }
        public DbSet<HizmetAltKategori>? HizmetAltKategoris { get; set; }


        #endregion





        #region İlanlar

        public DbSet<Ilan> Ilans { get; set; }

        #region TemizlikHizmetleri Dbset
       
             
        
        
        public DbSet<ApartmanTemizlik>? ApartmanTemizliks { get; set; }
        public DbSet<BosEvTemizlik>? BosEvTemizliks { get; set; }
        public DbSet<CamTemizlik>? CamTemizliks { get; set; }
        public DbSet<EvdeHaliYikama>? EvdeHaliYikamas { get; set; }
        public DbSet<EvdeUtu>? EvdeUtus { get; set; }
        public DbSet<EvTemizlik>? EvTemizliks { get; set; }
        public DbSet<HaliYikama>? HaliYikamas { get; set; }
        public DbSet<Ilaclama>? Ilaclamas { get; set; }
        public DbSet<InsaatSonrasiTemizlik>? InsaatSonrasiTemizliks { get; set; }
        public DbSet<IsyeriTemizlik>? IsyeriTemizliks { get; set; }
        public DbSet<KoltukTemizlik>? KoltukTemizliks { get; set; }
        public DbSet<KuruTemizleme>? KuruTemizlemes { get; set; }
        public DbSet<MermerCilalama>? MermerCilalamas { get; set; }
        public DbSet<StorPerdeYikama>? StorPerdeYikamas { get; set; }
        public DbSet<YatakYikama>? YatakYikamas { get; set; }

        public DbSet<YorganYikama>? YorganYikamas { get; set; }



        #endregion

        #region Tadilat Dekorasyon DbSet
        public DbSet<Tadilat>? Tadilats { get; set; }
        public DbSet<AlciIsleri>? AlciIsleris { get; set; }
        public DbSet<AlcipanIsleri>? AlcipanIsleris { get; set; }
        public DbSet<AnahtarTeslimInsaat>? AnahtarTeslimInsaats { get; set; }
        public DbSet<BahceBakimi>? BahceBakimis { get; set; }
        public DbSet<BalkonFilesi>? BalkonFilesis { get; set; }
        public DbSet<BanyoTadilat>? BanyoTadilats { get; set; }
        public DbSet<BinaGuclendirme>? BinaGuclendirmes { get; set; }
        public DbSet<BoyaBadana>? BoyaBadanas { get; set; }
        public DbSet<CamBalkon>? CamBalkons { get; set; }
        public DbSet<CatiTadilati>? CatiTadilatis { get; set; }
        public DbSet<CelikEvYapimi>? CelikEvYapimis { get; set; }
        public DbSet<CelikKapi>? CelikKapis { get; set; }
        public DbSet<DemirKaynak>? DemirKaynaks { get; set; }
        public DbSet<DepremTesti>? DepremTestis { get; set; }
        public DbSet<DogalgazTesisatiVeProjesi>? DogalgazTesisatiVeProjesis { get; set; }
        public DbSet<DolapYapimi>? DolapYapimis { get; set; }
        public DbSet<Dusakabin>? Dusakabins { get; set; }
        public DbSet<DuvarKagidiIsleri>? DuvarKagidiIsleris { get; set; }
        public DbSet<EpoksiZeminKaplama>? EpoksiZeminKaplamas { get; set; }
        public DbSet<EvDekorasyon>? EvDekorasyons { get; set; }
        public DbSet<EvTadilat>? EvTadilats { get; set; }
        public DbSet<FayansDoseme>? FayansDosemes { get; set; }
        public DbSet<GunesEnerjisi>? GunesEnerjisis { get; set; }
        public DbSet<HavuzYapimi>? HavuzYapimis { get; set; }
        public DbSet<HazirRuloCim>? HazirRuloCims { get; set; }
        public DbSet<KabaInsaat> KabaInsaats { get; set; }
        public DbSet<KapiPencereSinekligi> KapiPencereSinekligis { get; set; }
        public DbSet<KoltukDoseme> KoltukDosemes { get; set; }
        public DbSet<LaminatParkeDoseme> LaminatParkeDosemes { get; set; }
        public DbSet<Mantolama> Mantolamas { get; set; }
        public DbSet<MezarYapimi> MezarYapimis { get; set; }
        public DbSet<MimariProjeCizimi> MimariProjeCizimis { get; set; }
        public DbSet<MobilyaBoyama> MobilyaBoyamas { get; set; }
        public DbSet<MutfakDolabiYapimi> MutfakDolabiYapimis { get; set; }
        public DbSet<MutfakTadilat> MutfakTadilats { get; set; }
        public DbSet<MutfakTezgahi> MutfakTezgahis { get; set; }
        public DbSet<OtomatikKepenk> OtomatikKepenks { get; set; }
        public DbSet<OzelMobilyaYapimi> OzelMobilyaYapimis { get; set; }
        public DbSet<Panjur> Panjurs { get; set; }
        public DbSet<ParkeSistreCila> ParkeSistreCilas { get; set; }
        public DbSet<ParkeTasiDoseme> ParkeTasiDosemes { get; set; }
        public DbSet<PrefabrikEvYapimi> PrefabrikEvYapimis { get; set; }
        public DbSet<PVCKapiPencereBalkon> PVCKapiPencereBalkons { get; set; }
        public DbSet<SeramikDoseme> SeramikDosemes { get; set; }
        public DbSet<SesYalitimi> SesYalitimis { get; set; }
        public DbSet<StorPerde> StorPerdes { get; set; }
        public DbSet<SupurgelikMontaji> SupurgelikMontajis { get; set; }
        public DbSet<SurguluKapi> SurguluKapis { get; set; }
        public DbSet<SuYalitimi> SuYalitimis { get; set; }
        public DbSet<TelOrguCiti> TelOrguCitis { get; set; }
        public DbSet<TenteBrandaTadilatVeDekorasyon> TenteBrandaTadilatVeDekorasyons { get; set; }





       

        #endregion

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-7FIIBG4;Database=BideryaMvcProjesiSira3;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
            //"Data Source =DESKTOP-F43C5LA\\SQLEXPRESS; Initial Catalog=BideryaMvcProjesi; User ID=sa;password=servet;TrustServerCertificate=True"    evdeki database linki
            //"Server=DESKTOP-7FIIBG4;Database=BideryaMvcProjesiSira1;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True" Laptop Linki
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Kullanıcı Ve KullanıcıAdres Entityleri Fluent Api

            modelBuilder.Entity<Kullanici>() //buradada fluent api olarak tablolar arasındaki ilişkiyi belirledik..
               .HasMany(a => a.KullaniciAdress)
               .WithOne(p => p.Kullanici);


            //Burada Shadow property oluşturduk ve bunu kayıt tarihini bastık...

            modelBuilder.Entity<Kullanici>()
                .Property(a => a.Ad).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Kullanici>().Property(a => a.Sifre1).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Kullanici>().Property(a => a.Sifre2).IsRequired().HasMaxLength(100);

            #endregion


            #region Seed Datalar
            modelBuilder.Entity<Kullanici>().HasData(
            new Kullanici
            {
                Id = 1,
                Ad = "Ahmet",
                Soyad = "Yılmaz",
                Sifre1 = "3A987843C71CDC036B1477D929084804",
                Sifre2 = "3A987843C71CDC036B1477D929084804",
                Email = "ahmet.yilmaz@gmail.com",
                TelNo = "05555555555",
                KayitTarihi = DateTime.Now,
            },
            new Kullanici
            {
                Id = 2,
                Ad = "Ayşe",
                Soyad = "Kaya",
                Sifre1 = "3A987843C71CDC036B1477D929084804",
                Sifre2 = "3A987843C71CDC036B1477D929084804",
                Email = "ayse@gmail.com",
                TelNo = "05555555555",
                KayitTarihi = DateTime.Now,
            }
              );
            modelBuilder.Entity<KullaniciAdres>().HasData(
                new KullaniciAdres()
                {
                    Id = 1,
                    KullaniciId = 1,
                    Adresbasligi = "Ev Adresi",
                    Il = "Ankara",
                    Ilce = "Sincan",
                    Mahalle = "Yeniken",
                    AdresGenel = "Yenikent Ankara"
                });
            modelBuilder.Entity<KullaniciAdres>().HasData(
                new KullaniciAdres()
                {
                    Id = 2,
                    KullaniciId = 1,
                    Adresbasligi = "İş Adresi",
                    Il = "Ankara",
                    Ilce = "Sincan",
                    Mahalle = "Yeniken",
                    AdresGenel = "Yenikent Ankara"
                });
            modelBuilder.Entity<KullaniciAdres>().HasData(
                new KullaniciAdres()
                {
                    Id = 3,
                    KullaniciId = 1,
                    Adresbasligi = "Dükkan Adresi",
                    Il = "Ankara",
                    Ilce = "Sincan",
                    Mahalle = "Yeniken",
                    AdresGenel = "Yenikent Ankara"
                });
            modelBuilder.Entity<KullaniciAdres>().HasData(
                new KullaniciAdres()
                {
                    Id = 4,
                    KullaniciId = 2,
                    Adresbasligi = "Ev Adresi",
                    Il = "Ankara",
                    Ilce = "Sincan",
                    Mahalle = "Yeniken",
                    AdresGenel = "Yenikent Ankara"
                });
            modelBuilder.Entity<KullaniciAdres>().HasData(
                new KullaniciAdres()
                {
                    Id = 5,
                    KullaniciId = 2,
                    Adresbasligi = "İş Adresi",
                    Il = "Ankara",
                    Ilce = "Sincan",
                    Mahalle = "Yeniken",
                    AdresGenel = "Yenikent Ankara"
                });
            modelBuilder.Entity<KullaniciAdres>().HasData(
                new KullaniciAdres()
                {
                    Id = 6,
                    KullaniciId = 2,
                    Adresbasligi = "Dükkan Adresi",
                    Il = "Ankara",
                    Ilce = "Sincan",
                    Mahalle = "Yeniken",
                    AdresGenel = "Yenikent Ankara"
                });
            modelBuilder.Entity<Ilan>().HasData(new Ilan()
            {
                Id = 1,
                KullaniciId =1,
                Il = "Ankara",
                Ilce ="Yenikent",
                IlanKategoriId =1,
                IlanBaslik ="Ev Temizlik",
                IlanAltKategoriId =1,
                AdresDetay ="Ayaş Merkez"
            });
            modelBuilder.Entity<EvTemizlik>().HasData(new EvTemizlik()
            {
                Id = 1,
                IlanId= 1,
                BalkonSayisi = 1,
                BanyoSayisi = 1,
                CalismaSuresi =3,
                OdaSayisi = 1,
                HayvanVarmi =false,
                Aciklama ="Temizlenecek"
            });

            modelBuilder.Entity<HizmetVeren>().HasData(new HizmetVeren()
            {Id =1,
                Ad ="servet",
                Soyad ="zabun",
                Sehir ="ankara",
                Sifre1 ="3A987843C71CDC036B1477D929084804",
                Sifre2 ="3A987843C71CDC036B1477D929084804",
                Email ="servet@gmail.com",
                FirmaIsmi="BeautyElla",
                HizmetKategoriId =1,
               TelNo ="05455503341",
               IsTelNo ="05455503341",
               SilinmeTarihi =null,
               KayitTarihi =DateTime.Now,
               VergiNo ="11111111111",
               
            });


            #endregion





        }
    }
}
