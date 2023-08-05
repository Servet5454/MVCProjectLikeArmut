using BideryaMvcProject.DataBase.Entities.Ilanlar;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class EvdeUtu
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = 1;// TEMİZLİK KATEGORİ
        public int IlanAltKategoriId { get; set; }

        public string? ParcaSayisi { get; set; }
        public string? Nevresim { get; set; }
        public string? IlanBaslik { get; set; } = "Evde Ütü Hizmeti";


        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        public DateTime YayinlanmaTarihi { get; set; } = DateTime.Now;

        public string? Aciklama { get; set; }
        public Ilan? Ilan { get; set; }
    }
}
