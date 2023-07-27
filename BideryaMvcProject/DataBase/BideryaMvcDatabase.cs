using BideryaMvcProject.DataBase.Entities.Hizmetler;
using BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon;
using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;
using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.DataBase.Entities.Kullanici;
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

        #region Tadilat Dekorasyon DbSet
        public DbSet<TadilatDekorasyon>? TadilatDekorasyons { get; set; }
        public DbSet<CamBalkon>? CamBalkons { get; set; }
        public DbSet<EvTadilat>? EvTadilats { get; set; }
        public DbSet<Mantolama>? Mantolamas { get; set; }
        public DbSet<MutfakDolabiYapimi>? MutfakDolabiYapimis { get; set; }

        #endregion

        #region TemizlikHizmetleri Dbset
        public DbSet<TemizlikAna>? TemizlikAnas { get; set; }
        public DbSet<AracYikama>? AracYikamas { get; set; }
        public DbSet<EvTemizlik>? EvTemizliks { get; set; }
        public DbSet<Ilaclama>? Ilaclamas { get; set; }
        public DbSet<KoltukTemizlik>? KoltukTemizliks { get; set; }
       
        #endregion

        #region İlanlar

        public DbSet<AnkaraHizmetIlani>? AnkaraHizmetIlanis { get; set; }
        public DbSet<AnkaraIlanKoltukTemizlik>? AnkaraIlanTemizliks { get; set; }


        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =DESKTOP-F43C5LA\\SQLEXPRESS; Initial Catalog=BideryaMvcProjesi10; User ID=sa;password=servet;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
            //"Data Source =DESKTOP-F43C5LA\\SQLEXPRESS; Initial Catalog=BideryaMvcProjesi; User ID=sa;password=servet"    evdeki database linki
            //"Server=DESKTOP-7FIIBG4;Database=BideryaMvcProjesi;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True" Laptop Linki
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
                Sifre1 = "123456",
                Sifre2 = "123456",
                Email = "ahmet.yilmaz@gmail.com",
                TelNo = "05555555555",
                KayitTarihi = DateTime.Now,
            },
            new Kullanici
            {
                Id = 2,
                Ad = "Ayşe",
                Soyad = "Kaya",
                Sifre1 = "678900",
                Sifre2 = "678900",
                Email = "ayse.kaya@gmail.com",
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





            #endregion





        }
    }
}
