using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class EvdeHaliYikamaViewModel:IlanAdresGenelBilgi
    {

        public int Id { get; set; }
        public string? HaliMetrekare { get; set; }
        public bool LekeCikarma { get; set; }

    }
}
