namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class InsaatSonrasiTemizlikViewModel
    {
        public int IlanKategoriId { get; set; }
        public int IlanAltKategoriId { get; set; }
        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        public int OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }
        public string? Metrekare { get; set; }
        public string? EvinDurumu { get; set; }
        public string? IlanBaslik { get; set; } = "İnşaat Sonrası Temizlik";
    }
}
