using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class BanyoTadilatViewModel : IlanAdresGenelBilgi
    {
        public string? IlanBaslik { get; set; } = "Banyo Tadilatı";

        public string? Tur { get; set; }
        public string? Metrekare { get; set; }
        public string? Malzeme { get; set; }
        

    }
}
