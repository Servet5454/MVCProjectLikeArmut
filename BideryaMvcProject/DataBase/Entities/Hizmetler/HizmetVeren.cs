using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;
using System.ComponentModel.DataAnnotations;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler
{
    public class HizmetVeren
    {
        public int Id { get; set; }
        public int KategoriId { get; set; } //TODO Burada enum ile hizmet işlemleri ayarlanacak...
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Sifre1 { get; set; }
        public string? Sifre2 { get; set; }
        public string? Email { get; set; }
        public string? TelNo { get; set; }
        public string? IsTelNo { get; set; }
        public int? VergiNo { get; set; }
        public string? FirmaIsmi { get; set; }
        
        
       

        public string? HizmetBolge { get; set; }
        public DateTime? KayitTarihi { get; set; } = DateTime.Now;
        public DateTime? SilinmeTarihi { get; set; }

        public ICollection<HizmetVerenAdres>? HizmetverenAdres { get; set; } //burada Hizmetveren adresle çok ilişkisi olduğunu söyledik...
        public ICollection<AracYikama>? AracYikamas { get; set; }
    }
}
