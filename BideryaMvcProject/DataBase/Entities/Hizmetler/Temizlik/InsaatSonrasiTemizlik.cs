using BideryaMvcProject.DataBase.Entities.Ilanlar;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class InsaatSonrasiTemizlik
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = 1;// TEMİZLİK KATEGORİ        
        public int IlanAltKategoriId { get; set; }
        public int OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }
        public string? Metrekare { get; set; }
        public string? EvinDurumu { get; set; }
        public string? IlanBaslik { get; set; } = "İnşaat Sonrası Temizlik";
        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Aciklama { get; set; }


        public DateTime YayinlanmaTarihi { get; set; } = DateTime.Now;

        public virtual Ilan? Ilan { get; set; }
    }
}
