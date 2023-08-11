using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class BinaGuclendirmeViewModel :IlanAdresGenelBilgi
    {
        public string? IlanBaslik { get; set; } = "Bina Güçlendirme";
        public string? BlokSayisi { get; set; }
        public string? KatSayisi { get; set; }
        public string? TabanAlani { get; set; }

    }
}
