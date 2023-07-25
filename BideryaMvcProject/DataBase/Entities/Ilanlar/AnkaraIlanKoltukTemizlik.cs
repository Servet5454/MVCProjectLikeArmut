using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Ilanlar
{
    public class AnkaraIlanKoltukTemizlik
    {
        public int Id { get; set; }        
        public int HizmetTuruId { get; set; }
        public int HizmetAltKategori { get; set; }
        public int TekliKoltukSayisi { get; set; }
        public int IkiliKoltukSayisi { get; set; }
        public int UcluKoltukSayisi { get; set; }
        public int LKoltukSayisi { get; set; }
        public int SandalyeSayisi { get; set; }
        public int MinderSayisi { get; set; }
        public int TekliYatakSayisi { get; set; }
        public int CiftKisilikYatakSayisi { get; set; }
        public string? HizmetBolge { get; set; }
        public string? Aciklama { get; set; }


        public AnkaraHizmetIlani? AnkaraHizmetIlani { get; set; }
    }
}
