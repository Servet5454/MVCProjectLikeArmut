using BideryaMvcProject.Helper.IlanHelpers;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class MermerCilalamaViewModel
    {
        #region Standarlar
        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik);
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.MermerCilalama);
        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        public string? IlanBaslik { get; set; } = "Mermer Cilalama";
        #endregion
        public string? MekanTipi { get; set; }
        public string? Metrekare { get; set; }



    }
}
