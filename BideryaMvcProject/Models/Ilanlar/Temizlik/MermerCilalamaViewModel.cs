using BideryaMvcProject.Helper.IlanHelpers;
using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class MermerCilalamaViewModel :IlanAdresGenelBilgi
    {
        
        public string? MekanTipi { get; set; }
        public string? Metrekare { get; set; }


        public string? IlanBaslik { get; set; } = "Mermer Cilalama";
    }
}
