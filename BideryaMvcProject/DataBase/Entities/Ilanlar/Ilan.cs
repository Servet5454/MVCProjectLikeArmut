using BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon;
using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;
using BideryaMvcProject.DataBase.Entities.Kullanicilar;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Ilanlar
{
    public class Ilan
    {
        public int Id { get; set; }
        [ForeignKey(nameof(KullaniciId))]
        public int KullaniciId { get; set; }
        public int IlanKategoriId { get; set; }
        public int IlanAltKategoriId { get; set; }
        public string? IlanAltKategoriBaslik { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? AdresDetay { get; set; }

        public virtual Kullanici? Kullanici { get; set; }
        public virtual CamBalkon? CamBalkon { get; set; }
        public virtual EvTadilat? EvTadilat { get; set; }
        public virtual Mantolama? Mantolama { get; set; }
        public virtual MutfakDolabiYapimi? MutfakDolabiYapimi { get; set; }

        public virtual AracYikama? AracYikama { get; set; }
        public virtual EvTemizlik? EvTemizlik { get; set; }
        public virtual Ilaclama? Ilaclama { get; set; }
        public virtual KoltukTemizlik? KoltukTemizlik { get; set; }




    }
}
