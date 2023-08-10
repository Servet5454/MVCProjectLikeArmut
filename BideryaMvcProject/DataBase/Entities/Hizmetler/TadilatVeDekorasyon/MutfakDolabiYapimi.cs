using BideryaMvcProject.DataBase.Entities.Ilanlar;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon
{
    public class MutfakDolabiYapimi
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }        
        public string? IsTuru { get; set; }
        public string? MalzemeTercihi { get; set; }
        public short ToplamDolapUzunluk { get; set; }
        public string? Aciklama { get; set; }
        public virtual Tadilat? Tadilat { get; set; }

    }
}
