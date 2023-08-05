using BideryaMvcProject.DataBase.Entities.Ilanlar;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class YatakYikama
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = 1;// TEMİZLİK KATEGORİ
        public int IlanAltKategoriId { get; set; }


        public Ilan? Ilan { get; set; }
    }
}
