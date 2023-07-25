using BideryaMvcProject.DataBase.Entities.Kullanici;

namespace BideryaMvcProject.DataBase.Entities.Ilanlar
{
    public class AnkaraHizmetIlani
    {
        public AnkaraHizmetIlani()
        {
            AnkaraIlanTemizliks =new HashSet<AnkaraIlanKoltukTemizlik>();
        }
        public int Id { get; set; }
        public int HizmetTuru { get; set; }
        public int HizmetAltKategori { get; set; }
        public int TeklifSayisi { get; set; } = 0;
        public DateTime IlanTarih { get; set; } = DateTime.Now;
        public string? HizmetBolge { get; set; }

        public ICollection<AnkaraIlanKoltukTemizlik>? AnkaraIlanTemizliks { get; set; }
    }
}
