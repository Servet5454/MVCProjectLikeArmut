using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class CamTemizlikViewModel :IlanAdresGenelBilgi
    {
        
        public string? EvBuyukluk { get; set; }
        public string? Balkon { get; set; }

        public string? IlanBaslik { get; set; } = "Cam Temizliği";

    }
}
