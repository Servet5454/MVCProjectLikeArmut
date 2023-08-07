using BideryaMvcProject.DataBase.Entities.Ilanlar;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class YatakYikama
    {
        #region DefaultDegerler
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = 1;// TEMİZLİK KATEGORİ
        public int IlanAltKategoriId { get; set; }

        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        public string? IlanBaslik { get; set; } = "Yatak Yıkama";
        public DateTime YayinlanmaTarihi { get; set; } = DateTime.Now;
        #endregion



        #region Adres 
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Aciklama { get; set; }
        #endregion




        public string? Adet { get; set; }
        public string? Buyukluk { get; set; }
        public bool LekeVarmi { get; set; }
        

        public Ilan? Ilan { get; set; }
    }
}
