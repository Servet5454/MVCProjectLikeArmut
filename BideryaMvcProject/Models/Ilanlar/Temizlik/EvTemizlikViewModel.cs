using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class EvTemizlikViewModel
    {
        public int Id { get; set; }
        public bool Aktifmi { get; set; } = false;    
        public string? OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }       
        public float CalismaSuresi { get; set; }
        public bool? HayvanVarmi { get; set; }
        public string? Aciklama { get; set; }

    }
}
