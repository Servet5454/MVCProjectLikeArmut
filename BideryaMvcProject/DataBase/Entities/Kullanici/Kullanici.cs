using System.Numerics;

namespace BideryaMvcProject.DataBase.Entities.Kullanici
{
    public class Kullanici
    {

        public Kullanici()
        {
            KullaniciAdress = new HashSet<KullaniciAdres>();
            Ilans = new HashSet<Ilan>();
        }

        public int Id { get; set; }
        public string? Ad { get; set; }

        public string? Soyad { get; set; }
        public string? Sifre1 { get; set; }
        public string? Sifre2 { get; set; }
        public string? Email { get; set; }
        public string? TelNo { get; set; }
        public DateTime? KayitTarihi { get; set; } = DateTime.Now;


        public ICollection<Ilan>? Ilans { get; set; }
        public ICollection<KullaniciAdres>? KullaniciAdress { get; set; } //burada kullanıcı adresle çok ilişkisi olduğunu söyledik...
        public ICollection<IlanAltKategori>? IlanAltKategoris { get; set; }
    }
}
