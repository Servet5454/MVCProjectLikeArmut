using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;
using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class EvTemizlikViewModel : IlanAdresGenelBilgi
    {
        public int Id { get; set; }
        public int IlanKategoriId { get; set; }
        public int IlanAltKategoriId { get; set; }
        public bool Aktifmi { get; set; } = false;    
        public int OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }       
        public int CalismaSuresi { get; set; }
        public bool? HayvanVarmi { get; set; }
        public string? Aciklama { get; set; }

    }
}
