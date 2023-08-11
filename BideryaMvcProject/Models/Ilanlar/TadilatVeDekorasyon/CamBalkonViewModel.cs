using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class CamBalkonViewModel : IlanAdresGenelBilgi
    {
        public string? IlanBaslik { get; set; } = "Cam Balkon";
        public string? CamBalkonTuru { get; set; }
        public int BalkonCevresi { get; set; }
        public int BalkonYukseklik { get; set; }
        public string? BalkonCephe { get; set; }
        public string? CamRengi { get; set; }
        

       
    }
}
