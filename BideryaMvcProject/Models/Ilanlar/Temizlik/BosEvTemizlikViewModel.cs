using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class BosEvTemizlikViewModel:IlanAdresGenelBilgi
    {
        public int IlanKategoriId { get; set; }
        public int IlanAltKategoriId { get; set; }
        public string? OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }
        public string? EvinDurumu { get; set; }

    }
}
