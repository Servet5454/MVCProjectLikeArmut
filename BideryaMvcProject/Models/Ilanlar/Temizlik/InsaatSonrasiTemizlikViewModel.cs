using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class InsaatSonrasiTemizlikViewModel :IlanAdresGenelBilgi
    {
       
        public int OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }
        public string? Metrekare { get; set; }
        public string? EvinDurumu { get; set; }
    }
}
