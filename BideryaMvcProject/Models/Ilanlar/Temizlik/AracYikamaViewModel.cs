using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class AracYikamaViewModel:IlanAdresGenelBilgi
    {
        
        public int AltKategoriId { get; set; }
        public int KoltukSayisi { get; set; }
        public string? DigerYerler { get; set; }
        public string? Aciklama { get; set; }
    }
}
