using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class StorPerdeViewModel
    {      

        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Aciklama { get; set; }

        public string? Metrekare { get; set; }
        public string? Adet { get; set; }
        public string? Kornis { get; set; }

    }
}
