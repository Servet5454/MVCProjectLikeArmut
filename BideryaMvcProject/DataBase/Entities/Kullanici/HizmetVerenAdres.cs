namespace BideryaMvcProject.DataBase.Entities.Kullanici
{
    public class HizmetVerenAdres
    {
        public int Id { get; set; }
        public int HizmetVerenId { get; set; } //bu yaptığımız tanımlama ile foreign key tanımlamış oluyoruz...
        public string? Adresbasligi { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public string? AdresGenel { get; set; }
        public string? AdresAd { get; set; }
        public string? AdresSoyad { get; set; }
        public string? AdresTel { get; set; }
        public HizmetVeren? HizmetVeren { get; set; } //Burada hizmetveren entity'si ile ilişkisini yaptık...
    }
}
