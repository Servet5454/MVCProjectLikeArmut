using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class KuruTemizlemeViewModel:IlanAdresGenelBilgi
    {
        public string? Ceket { get; set; }
        public string? Pantalon { get; set; }
        public string? Gomlek { get; set; }

        public string? Mont { get; set; }
        public string? Gelinlik { get; set; }
        public string? Yorgan { get; set; }
        public string? IlanBaslik { get; set; } = "Kuru Temizleme";
    }
}
