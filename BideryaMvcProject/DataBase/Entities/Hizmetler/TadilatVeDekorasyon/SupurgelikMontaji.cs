using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon
{
    public class SupurgelikMontaji
    {
        public int Id { get; set; }
        public int TadilatId { get; set; }

        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon);
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.SupurgelikMontaji);
        public string? IlanBaslik { get; set; } = "Süpürgelik Montajı";




        public string? Aciklama { get; set; }

        public virtual Tadilat? Tadilat { get; set; }
    }
}
