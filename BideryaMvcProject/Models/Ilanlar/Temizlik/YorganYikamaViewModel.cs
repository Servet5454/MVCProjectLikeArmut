using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class YorganYikamaViewModel:IlanAdresGenelBilgi
    {
        public string? CiftKisilikSayisi { get; set; }
        public string? TekKisilikSayisi { get; set; }

        public bool LekeVarmi { get; set; }
    }
}
