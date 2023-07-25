namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Models.Ilanlar
{
    public class KoltukTemizlikViewModel
    {
        public int Id { get; set; }
        public int HizmetTuru { get; set; }
        public int HizmetAltKategori { get; set; }
        public int TekliKoltuk { get; set; }
        public int IkiliKoltuk { get; set; }
        public int UcluKoltuk { get; set; }
        public int LKoltuk { get; set; }
        public int Minder { get; set; }
        public int Sandalye { get; set; }
        public int YatakSayi { get; set; }
        public int CiftKisilikYatakSayi { get; set; }
        public string? AdresSehir { get; set; }
        public int TeklifSayisi { get; set; }
        public string? Aciklama { get; set; }

    }
}
