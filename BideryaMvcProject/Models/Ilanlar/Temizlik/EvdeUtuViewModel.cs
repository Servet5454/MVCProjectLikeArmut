using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class EvdeUtuViewModel:IlanAdresGenelBilgi
    {
        public int ParcaSayisi { get; set; }
        public int Nevresim { get; set; }
        public string? IlanBaslik { get; set; } = "Evde Ütü Hizmeti";



    }
}
