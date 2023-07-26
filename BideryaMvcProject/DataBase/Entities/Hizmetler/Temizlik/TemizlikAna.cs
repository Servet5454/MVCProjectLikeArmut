namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class TemizlikAna
    {
        public int Id { get; set; }
        public int HizmetKategoriId { get; set; }
        public int AltKategoriId { get; set; }
        public string? HizmetServis { get; set; }
        public short? BanyoSayisi { get; set; }
        public float? CalismaSuresi { get; set; }
        public bool HayvanVarmi { get; set; } = false;
        public string? Aciklama { get; set; }
        public bool EvBosmu { get; set; }





    }
}
