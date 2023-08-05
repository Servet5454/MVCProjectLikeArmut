using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class ApartmanTemizlikViewModel:IlanAdresGenelBilgi
    {
        public int IlanKategoriId { get; set; } = 1;
        public int IlanAltKategoriId { get; set; }
        public int DaireSayisi { get; set; }
        public bool CopToplama { get; set; }
        public string? IlanBaslik { get; set; } = "Apartman Temizliği";

    }
}
