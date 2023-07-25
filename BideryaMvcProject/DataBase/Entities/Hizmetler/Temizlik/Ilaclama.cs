namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class Ilaclama
    {
        public Guid Id { get; set; }
        public int KategoriId { get; set; }
        public string? HasereTipi { get; set; }
        public int Metrekare { get; set; }
        public string? MekanTipi { get; set; }
        public string? Aciklama { get; set; }

    }
}
