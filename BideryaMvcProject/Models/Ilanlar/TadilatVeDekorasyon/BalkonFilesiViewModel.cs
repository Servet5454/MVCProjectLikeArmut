using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class BalkonFilesiViewModel : IlanAdresGenelBilgi
    {
        public string? IlanBaslik { get; set; } = "Balkon Filesi";


        public string? Tur { get; set; }
        public string? Metrekare { get; set; }
    }
}
