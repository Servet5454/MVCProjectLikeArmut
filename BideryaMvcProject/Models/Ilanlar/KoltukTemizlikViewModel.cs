namespace BideryaMvcProject.Models.Ilanlar
{
    public class KoltukTemizlikViewModel
    {
        public int Id { get; set; }
        public int TekliKoltuk { get; set; }
        public int IkiliKoltuk { get; set;}
        public int UcluKoltuk { get; set; }
        public int LKoltuk { get; set; }
        public int Minder {get; set;}
        public int Sandalye { get; set;}
        public int yatakSayi { get; set; }
        public string? Aciklama { get; set; }

    }
}
