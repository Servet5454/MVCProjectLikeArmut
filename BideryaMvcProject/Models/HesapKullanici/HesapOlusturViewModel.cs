namespace BideryaMvcProject.Models.HesapKullanici
{
    public class HesapOlusturViewModel
    {
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Sifre1 { get; set; }
        public string? Sifre2 { get; set; }
        public string? Email { get; set; }
        public string? TelNo { get; set; }
        public string? IsTelNo { get; set; }
        public int? VergiNo { get; set; }
        public string? FirmaIsmi { get; set; }

        public string? HizmetTuru { get; set; } //TODO Burada enum ile hizmet işlemleri ayarlanacak...

        public string? HizmetBolge { get; set; }

    }
}
