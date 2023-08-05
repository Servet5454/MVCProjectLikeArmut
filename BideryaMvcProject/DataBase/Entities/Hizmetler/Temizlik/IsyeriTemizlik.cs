using BideryaMvcProject.DataBase.Entities.Ilanlar;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class IsyeriTemizlik
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = 1;// TEMİZLİK KATEGORİ
        public int IlanAltKategoriId { get; set; }
        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        public string? Il { get; set; }
        public string? Ilce { get; set; }

        public string? IsyeriTipi { get; set; }
        public string? Metrekare { get; set; }

        public string? IlanBaslik { get; set; } = "İşyeri Temizlik";


        public string? Aciklama { get; set; }

        public DateTime YayinlanmaTarihi { get; set; } = DateTime.Now;



        public Ilan? Ilan { get; set; }
    }
}
