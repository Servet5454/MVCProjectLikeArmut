using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Kullanici
{
    public class IlanAltKategori
    {
        public int Id { get; set; }
        [ForeignKey(nameof(KullaniciId))]
        public int KullaniciId { get; set; }

        public int TekliKoltukSayisi { get; set; }
        public int IkiliKoltukSayisi { get; set; }
        public int UcluKoltukSayisi { get; set; }
        public int LKoltukSayisi { get; set; }
        public int SandalyeSayisi { get; set; }
        public int MinderSayisi { get; set; }
        public int TekliYatakSayisi { get; set; }
        public int CiftKisilikYatakSayisi { get; set; }
        public int TeklifSayisi { get; set; }

        public string? Aciklama { get; set; }





        public Ilan? Ilan { get; set; }

        public Kullanici? Kullanici { get; set; }
    }
}
