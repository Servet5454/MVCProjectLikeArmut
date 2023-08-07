using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class HaliYikama
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik);// TEMİZLİK KATEGORİ
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.HaliYikama);
        public string? Aciklama { get; set; }
        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        public string? Il { get; set; }
        public string? Ilce { get; set; }

        public string? HaliMetrekare { get; set; }
        public bool LekeCikarma { get; set; }


        public string? IlanBaslik { get; set; } = "Evde Halı Yıkama";
        public DateTime YayinlanmaTarihi { get; set; } = DateTime.Now;
        public Ilan? Ilan { get; set; }
    }
}
