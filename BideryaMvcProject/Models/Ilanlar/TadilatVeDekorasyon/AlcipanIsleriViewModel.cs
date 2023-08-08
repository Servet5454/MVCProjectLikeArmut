using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class AlcipanIsleriViewModel :IlanAdresGenelBilgi
    {
        public string? Metrekare { get; set; }
        public string? ExtraHizmet { get; set; }
        public string? Malzeme { get; set; }
    }
}
