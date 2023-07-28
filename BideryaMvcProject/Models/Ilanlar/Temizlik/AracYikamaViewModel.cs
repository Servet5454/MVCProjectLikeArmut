using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class AracYikamaViewModel:IlanAdres
    {
        public int Id { get; set; }
        public int TemizlikAnaId { get; set; }
        public int AltKategoriId { get; set; }
        public int KoltukSayisi { get; set; }
        public string? DigerYerler { get; set; }
        public string? Aciklama { get; set; }
    }
}
