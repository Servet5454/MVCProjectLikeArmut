using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class BosEvTemizlikViewModel:IlanAdresGenelBilgi
    {
        public string? OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }
        public string? EvinDurumu { get; set; }

    }
}
