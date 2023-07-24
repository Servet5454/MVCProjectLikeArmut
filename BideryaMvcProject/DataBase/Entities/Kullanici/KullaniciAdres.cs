namespace BideryaMvcProject.DataBase.Entities.Kullanici
{
    public class KullaniciAdres
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; } //bu yaptığımız tanımlama ile foreign key tanımlamış oluyoruz...
        public string? Adresbasligi { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public string? AdresGenel { get; set; }
        public string? AdresAd { get; set; }
        public string? AdresSoyad { get; set; }
        public string? AdresTel { get; set; }

        public Kullanici? Kullanici { get; set; } //Burada kullanıcı entity'si ile ilişkisini yaptık...
    }
}
