using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class YatakYikamaViewModel : IlanAdresGenelBilgi
    {
        public string? Adet { get; set; }
        public string? Buyukluk { get; set; }
        public bool LekeVarmi { get; set; }

    }
}
