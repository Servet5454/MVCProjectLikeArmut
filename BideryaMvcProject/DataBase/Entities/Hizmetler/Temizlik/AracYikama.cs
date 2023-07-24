namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class AracYikama
    {
        public Guid Id { get; set; }
        public int KoltukSayisi { get; set; }
        public string? DigerYerler { get; set; }
        public string? Aciklama { get; set; }

    }
}
