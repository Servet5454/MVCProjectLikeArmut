using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class CamTemizlik
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = 1;// TEMİZLİK KATEGORİ
        public int IlanAltKategoriId { get; set; }
        public string? EvBuyukluk { get; set; }
        public string? Balkon { get; set; }
    }
}
