using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;
using BideryaMvcProject.Helper.IlanHelpers;
using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class EvTemizlikViewModel : IlanAdresGenelBilgi
    {

        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik);
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.IsyeriTemizligi);
        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        public int OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }       
        public int CalismaSuresi { get; set; }
        public bool? HayvanVarmi { get; set; }
        public int BalkonSayisi { get; set; }
        
        public string? IlanBaslik { get; set; } = "Ev Temizliği";

    }
}
