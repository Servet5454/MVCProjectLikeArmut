using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class HaliYikamaViewModel:IlanAdresGenelBilgi
    {
        public string? HaliMetrekare { get; set; }
        public bool LekeCikarma { get; set; }
    }
}
