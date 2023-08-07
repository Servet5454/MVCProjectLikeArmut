using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class ApartmanTemizlikViewModel:IlanAdresGenelBilgi
    {
       
        public int DaireSayisi { get; set; }
        public bool CopToplama { get; set; }
        

    }
}
