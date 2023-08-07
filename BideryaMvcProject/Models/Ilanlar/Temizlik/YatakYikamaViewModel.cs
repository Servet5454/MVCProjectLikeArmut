using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class YatakYikamaViewModel : IlanAdresGenelBilgi
    {
        public string? CiftKisilikSayisi { get; set; }
        public string? TekKisilikSayisi { get; set; }
               
        public bool LekeVarmi { get; set; }

        public string? IlanBaslik { get; set; } = "Yatak Yıkama";

    }
}
