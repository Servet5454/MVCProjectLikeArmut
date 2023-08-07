using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class YorganYikama
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik);
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.YorganYikama);
        

        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Aciklama { get; set; }



        public string? CiftKisilikSayisi { get; set; }
        public string? TekKisilikSayisi { get; set; }
        public bool LekeVarmi { get; set; }



        public string? IlanBaslik { get; set; } = "Yorgan Yıkama";

        public DateTime YayinlanmaTarihi { get; set; } = DateTime.Now;
        public Ilan? Ilan { get; set; }
    }
}
