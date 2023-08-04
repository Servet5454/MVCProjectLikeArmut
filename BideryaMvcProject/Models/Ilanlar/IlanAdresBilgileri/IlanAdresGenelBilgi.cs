namespace BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri
{
    public class IlanAdresGenelBilgi
    {
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? AdresGenel { get; set; }
        public string? IlanBaslik { get; set; }
        public int TeklifSayisi { get; set; } = 0;
        public int IlanKategoriId { get; set; }
        public int IlanAltKategoriId { get; set; }
    }
}
