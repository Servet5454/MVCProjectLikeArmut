using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class BahceBakimiViewModel:IlanAdresGenelBilgi
    {
        public string? IlanBaslik { get; set; } = "Bahçe Bakımı";
        public string? HangiSiklik { get; set; }
        public string? BakimTuru { get; set; }
        public string? Sulama { get; set; }
        public string? Metrekare { get; set; }

    }
}
