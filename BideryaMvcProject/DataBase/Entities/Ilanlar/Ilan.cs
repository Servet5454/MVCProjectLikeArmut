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
        public virtual ICollection<CamBalkon>? CamBalkons { get; set; }
        public virtual ICollection<EvTadilat>? EvTadilats { get; set; }
        public virtual ICollection<Mantolama>? Mantolamas { get; set; }
        public virtual ICollection<MutfakDolabiYapimi>? MutfakDolabiYapimis { get; set; }

        public virtual ICollection<AracYikama>? AracYikamas { get; set; }
        public virtual ICollection<EvTemizlik>? EvTemizliks { get; set; }
        public virtual ICollection<Ilaclama>? Ilaclamas { get; set; }
        public virtual ICollection<KoltukTemizlik>? KoltukTemizliks { get; set; }




    }
}
