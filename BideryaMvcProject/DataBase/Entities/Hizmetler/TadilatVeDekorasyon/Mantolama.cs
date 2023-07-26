namespace BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon
{
    public class Mantolama
    {
        public int Id { get; set; }
        public int TadilatDekorasyonId { get; set; }
        public int BinaKatSayisi { get; set; }
        public int BinaCepheUzunluk { get; set; }
        public int KisaCepheUzunluk { get; set; }
        public int CepheSayisi { get; set; }
        public string? Ozellikler { get; set; }
        public string? MarkaTercih { get; set; }
        public int BalkonTipi { get; set; }
        public string? Aciklama { get; set; }

        
    }
}
