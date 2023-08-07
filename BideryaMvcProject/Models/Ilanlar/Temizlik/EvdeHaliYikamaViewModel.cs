using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class EvdeHaliYikamaViewModel:IlanAdresGenelBilgi
    {

        public string? IlanBaslik { get; set; } = "Evde Halı Yıkama";
        public string? HaliMetrekare { get; set; }
        public bool LekeCikarma { get; set; }
    }
}
