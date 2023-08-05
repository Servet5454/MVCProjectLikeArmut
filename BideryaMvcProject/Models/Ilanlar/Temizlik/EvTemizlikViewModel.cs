using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;
using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class EvTemizlikViewModel : IlanAdresGenelBilgi
    {
        
        public int IlanKategoriId { get; set; }
        public int IlanAltKategoriId { get; set; }
        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        public int OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }       
        public int CalismaSuresi { get; set; }
        public bool? HayvanVarmi { get; set; }
        
        public string? IlanBaslik { get; set; } = "Ev Temizliği";

    }
}
