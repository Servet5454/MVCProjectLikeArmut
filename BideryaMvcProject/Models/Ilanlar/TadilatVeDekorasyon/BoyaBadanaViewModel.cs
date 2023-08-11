using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class BoyaBadanaViewModel : IlanAdresGenelBilgi
    {
        public string? IlanBaslik { get; set; } = "Boya Badana";

        public string? Metrekare { get; set; }
        public string? OdaSayisi { get; set; }
        public string? Malzeme { get; set; }
        public string? MalzemeKalitesi { get; set; }
        public string? EvinDurumu { get; set; }
        public string? Tavan { get; set; }

    }
}
