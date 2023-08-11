using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon
{
    public class BahceBakimi
    {
        public int Id { get; set; }
        public int TadilatId { get; set; }
        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon);
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BahceBakimi);
        public string? IlanBaslik { get; set; } = "Bahçe Bakımı";
        public string? Aciklama { get; set; }

        public virtual Tadilat? Tadilat { get; set; }
    }
}
