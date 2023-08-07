using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class EvTemizlik
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik);      
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.EvTemizlik);
        public int OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }
        public int BalkonSayisi { get; set; }
        public float CalismaSuresi { get; set; }
        public bool HayvanVarmi { get; set; }
        public string? Aciklama { get; set; }

        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        public string? Il { get; set; }
        public string? Ilce { get; set; }

        public string? IlanBaslik { get; set; } = "Ev Temizlik";

        public DateTime YayinlanmaTarihi { get; set; } = DateTime.Now;

        public virtual Ilan? Ilan { get; set; }

    }
}
