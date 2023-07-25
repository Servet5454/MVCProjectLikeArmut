namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class KoltukTemizlik
    {
        public Guid Id { get; set; }
        public int KategoriId { get; set; }
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

    }
}
