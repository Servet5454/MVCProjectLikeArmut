using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class AnahtarTeslimInsaatViewModel:IlanAdresGenelBilgi
    {
        public string? Kat { get; set; }
        public string? Daire { get; set; }
        public string? ProjeCizimi { get; set; }
        public string? OdemeSekli { get; set; }
        public string? BinaMalzemesi { get; set; }
        public string? MalzemeKalitesi { get; set; }
        public string? TabanAlani { get; set; }
        public string? ArsaDurumu { get; set; }
        public string? ImarIzni { get; set; }




    }
}
