using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class AracYikama
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(AltKategoriId))]
        public int AltKategoriId { get; set; }
        public int KoltukSayisi { get; set; }
        public string? DigerYerler { get; set; }
        public string? Aciklama { get; set; }

        public HizmetVeren? HizmetVeren { get; set; }
    }
}
