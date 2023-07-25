namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class EvTemizlik
    {
        public Guid Id { get; set; }
        public int KategoriId { get; set; }
        public string? OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }
        public int BalkonSayisi { get; set; }
        public float CalismaSuresi { get; set; }
        public string? HayvanVarmi { get; set; }
        public string? Aciklama { get; set; }

    }
}
