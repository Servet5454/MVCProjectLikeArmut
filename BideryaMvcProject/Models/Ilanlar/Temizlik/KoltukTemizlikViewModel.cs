using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class KoltukTemizlikViewModel : IlanAdresGenelBilgi
    {
        
        public int TekliKoltukSayisi { get; set; }
        public int IkiliKoltukSayisi { get; set; }
        public int UcluKoltukSayisi { get; set; }
       
        public int SandalyeSayisi { get; set; }
        public int MinderSayisi { get; set; }
        public int TekliYatakSayisi { get; set; }
        public int CiftKisilikYatakSayisi { get; set; }
       

    }
}
