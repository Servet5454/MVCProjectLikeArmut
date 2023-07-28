namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class CamBalkonViewModel
    {
        public int Id { get; set; }
        public int TadilatDekorasyonId { get; set; }
        public string? CamBalkonTuru { get; set; }
        public int BalkonCevresi { get; set; }
        public int BalkonYukseklik { get; set; }
        public string? BalkonCephe { get; set; }
        public string? CamRengi { get; set; }
        public string? Aciklama { get; set; }

        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? AdresDetay { get; set; }
    }
}
