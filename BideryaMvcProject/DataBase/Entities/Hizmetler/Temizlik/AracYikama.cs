using BideryaMvcProject.DataBase.Entities.Ilanlar;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class AracYikama
    {
        public int Id { get; set; }
        
        public int IlanId { get; set; }
        [ForeignKey(nameof(KullaniciId))]
        public int KullaniciId { get; set; }
        
        public int KoltukSayisi { get; set; }
        public string? DigerYerler { get; set; }
        public string? Aciklama { get; set; }

        public virtual Ilan? Ilan { get; set; }

    }
}
