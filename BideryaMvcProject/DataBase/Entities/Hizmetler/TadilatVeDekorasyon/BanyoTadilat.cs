using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon
{
    public class BanyoTadilat
    {
        public int Id { get; set; }
        public int TadilatId { get; set; }

        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon);
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BanyoTadilat);
        public string? IlanBaslik { get; set; } = "Banyo Tadilatı";

        public string? Tur { get; set; }
        public string? Metrekare { get; set; }
        public string? Malzeme { get; set; }

        public string? Aciklama { get; set; }

        public virtual Tadilat? Tadilat { get; set; }
    }
}
