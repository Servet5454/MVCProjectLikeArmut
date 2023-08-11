using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon
{
    public class BinaGuclendirme
    {
        public int Id { get; set; }
        public int TadilatId { get; set; }

        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon);
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BinaGuclendirme);
        public string? IlanBaslik { get; set; } = "Bina Güçlendirme";

        public string? BlokSayisi { get; set; }
        public string? KatSayisi { get; set; }
        public string? TabanAlani { get; set; }

        public string? Aciklama { get; set; }

        public virtual Tadilat? Tadilat { get; set; }
    }
}
