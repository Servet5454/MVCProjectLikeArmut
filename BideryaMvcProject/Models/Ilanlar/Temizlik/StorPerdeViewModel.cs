using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class StorPerdeViewModel :IlanAdresGenelBilgi
    {      
        public string? Metrekare { get; set; }
        public string? Adet { get; set; }
        public string? Kornis { get; set; }
        public string? IlanBaslik { get; set; } = "Stor Perde Yıkama";

    }
}
