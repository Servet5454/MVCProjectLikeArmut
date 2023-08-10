using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon
{
    public class AnahtarTeslimInsaat
    {
        public int Id { get; set; }
        public int TadilatId { get; set; }
        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon);
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.AnahtarTeslimInsaaat);
        public string? IlanBaslik { get; set; } = "Anahtar Teslim İnşaat";        
        public string? Aciklama { get; set; }



        public string? Kat { get; set; }
        public string? Daire { get; set; }
        public string? ProjeCizimi { get; set; }
        public string? OdemeSekli { get; set; }
        public string? BinaMalzemesi { get; set; }
        public string? MalzemeKalitesi { get; set; }
        public string? TabanAlani { get; set; }
        public string? ArsaDurumu { get; set; }
        public string? ImarIzni { get; set; }

        public virtual Tadilat? Tadilat { get; set; }
    }
}
