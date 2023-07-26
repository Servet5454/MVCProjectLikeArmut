using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class AracYikama
    {
        public int Id { get; set; }
        public int TemizlikAnaId { get; set; }
        public int AltKategoriId { get; set; }
        public int KoltukSayisi { get; set; }
        public string? DigerYerler { get; set; }
        public string? Aciklama { get; set; }


    }
}
