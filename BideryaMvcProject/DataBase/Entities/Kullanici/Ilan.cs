namespace BideryaMvcProject.DataBase.Entities.Kullanici
{
    public class Ilan
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }

        public int IlanKategori { get; set; }

        public Kullanici? Kullanici { get; set; }
        public ICollection<IlanAltKategori>? IlanAltKategoris { get; set; }
    }
}
