using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class AlciIsleriViewModel :IlanAdresGenelBilgi
    {
        public string? Metrekare { get; set; }
        public string? ExtraHizmet { get; set; }
        public string? Malzeme { get; set; }

    }
}
