using BideryaMvcProject.DataBase.Entities.Hizmetler;
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
        public DbSet<CamBalkon>? CamBalkons { get; set; }
        public DbSet<EvTadilat>? EvTadilats { get; set; }
        public DbSet<Mantolama>? Mantolamas { get; set; }
        public DbSet<MutfakDolabiYapimi>? MutfakDolabiYapimis { get; set; }

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
