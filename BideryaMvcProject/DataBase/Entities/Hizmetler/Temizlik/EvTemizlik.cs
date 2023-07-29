using BideryaMvcProject.DataBase.Entities.Ilanlar;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class EvTemizlik
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanAltKategoriId))]
        public int IlanAltKategoriId { get; set; }
        public int IlanId { get; set; }
        public int OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }
        public int BalkonSayisi { get; set; }
        public float CalismaSuresi { get; set; }
        public bool HayvanVarmi { get; set; }
        public string? Aciklama { get; set; }


        public virtual Ilan? Ilan { get; set; }

    }
}
