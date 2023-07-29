namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class MutfakDolabiYapimiViewModel
    {
        public int Id { get; set; }
        public int TadilatDekorasyonId { get; set; }
        public string? IsTuru { get; set; }
        public string? MalzemeTercihi { get; set; }
        public short ToplamDolapUzunluk { get; set; }
        public string? Aciklama { get; set; }

    }
}
