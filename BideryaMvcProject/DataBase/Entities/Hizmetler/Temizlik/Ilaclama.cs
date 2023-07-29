using BideryaMvcProject.DataBase.Entities.Ilanlar;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class Ilaclama
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanAltKategoriId))]
        public int IlanAltKategoriId { get; set; }
        public int IlanId { get; set; }
       
        public string? HasereTipi { get; set; }
        public int Metrekare { get; set; }
        public string? MekanTipi { get; set; }
        public string? Aciklama { get; set; }

        public virtual Ilan? Ilan { get; set; }

    }
}
