using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class AnahtarTeslimTadilatViewModel:IlanAdresGenelBilgi
    {
        public string? IlanBaslik { get; set; } = "Anahtar Teslim Tadilat";
        public string? Tur { get; set; }
        public string? Metrekare { get; set; }
        public string? Malzeme { get; set; }


    }
}
