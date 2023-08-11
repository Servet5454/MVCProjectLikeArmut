using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class BahceBakimiViewModel:IlanAdresGenelBilgi
    {
        public string? IlanBaslik { get; set; } = "Bahçe Bakımı";

    }
}
