namespace BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon
{
    public class CamBalkon
    {
        public int Id { get; set; }
        public int TadilatDekorasyonId { get; set; }
        public string? CamBalkonTuru { get; set; }
        public int BalkonCevresi { get; set; }
        public int BalkonYukseklik { get; set; }
        public string? BalkonCephe { get; set; }
        public string? CamRengi { get; set; }
        public string? Aciklama { get; set; }

        
    }
}
