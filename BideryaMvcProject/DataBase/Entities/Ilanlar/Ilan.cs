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
        public string? IlanBaslik { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? AdresDetay { get; set; }
        

        public virtual Kullanici? Kullanici { get; set; }
        public virtual ICollection<CamBalkon>? CamBalkons { get; set; }
        public virtual ICollection<EvTadilat>? EvTadilats { get; set; }
        public virtual ICollection<Mantolama>? Mantolamas { get; set; }
        public virtual ICollection<MutfakDolabiYapimi>? MutfakDolabiYapimis { get; set; }



        #region Temizlik Hizmetleri
        
        
        
        

        public virtual ICollection<ApartmanTemizlik>? ApartmanTemizliks { get; set; }
        public virtual ICollection<BosEvTemizlik>? BosEvTemizliks { get; set; }
        
        public virtual ICollection<CamTemizlik>? CamTemizliks { get; set; }
        public virtual ICollection<EvdeHaliYikama>? EvdeHaliYikamas { get; set; }
        public virtual ICollection<EvdeUtu>? EvdeUtus { get; set; }
        public virtual ICollection<EvTemizlik>? EvTemizliks { get; set; }
        public virtual ICollection<HaliYikama>? HaliYikamas { get; set; }
        public virtual ICollection<Ilaclama>? Ilaclamas { get; set; }
        public virtual ICollection<InsaatSonrasiTemizlik>? InsaatSonrasiTemizliks { get; set; }
        public virtual ICollection<IsyeriTemizlik>? IsyeriTemizliks { get; set; }
        public virtual ICollection<KoltukTemizlik>? KoltukTemizliks { get; set; }
        public virtual ICollection<KuruTemizleme>? KuruTemizlemes { get; set; }
        public virtual ICollection<MermerCilalama>? MermerCilalamas { get; set; }
        public virtual ICollection<StorPerdeYikama>? StorPerdeYikamas { get; set; }
        public virtual ICollection<YatakYikama>? YatakYikamas { get; set; }
        public virtual ICollection<YorganYikama>? YorganYikamas { get; set; }



        #endregion





    }
}
