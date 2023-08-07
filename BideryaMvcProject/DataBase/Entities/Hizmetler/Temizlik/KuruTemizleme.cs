using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class KuruTemizleme
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik);// TEMİZLİK KATEGORİ
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.KuruTemizleme);
        public string? Aciklama { get; set; }

        public string? Ceket { get; set; }
        public string? Pantalon { get; set; }
        public string? Gomlek { get; set; }

        public string? Mont { get; set; }
        public string? Gelinlik { get; set; }
        public string? Yorgan { get; set; }
        public string? IlanBaslik { get; set; } = "Kuru Temizleme";




        

        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;

        public string? Il { get; set; }
        public string? Ilce { get; set; }

        public DateTime YayinlanmaTarihi { get; set; } = DateTime.Now;
        public Ilan? Ilan { get; set; }
    }
}
