using BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon;
using BideryaMvcProject.Helper.IlanHelpers;

namespace BideryaMvcProject.DataBase.Entities.Ilanlar
{
    public class Tadilat
    {
        public int Id { get; set; }
        public int IlanId { get; set; }
        public int KategoriId { get; set; } = Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon);
        public int AltKategoriId { get; set; }

        public Ilan? Ilan { get; set; }
        public virtual ICollection<AhsapMerdiven>? AhsapMerdivens { get; set; }
        public virtual ICollection<AlciIsleri>? AlciIsleris { get; set; }
        public virtual ICollection<AlcipanIsleri>? AlcipanIsleris { get; set; }
        public virtual ICollection<AnahtarTeslimInsaat>? AnahtarTeslimInsaats { get; set; }
        public virtual ICollection<AnahtarTeslimTadilat>? AnahtarTeslimTadilats { get; set; }
        public virtual ICollection<BahceBakimi>? BahceBakimis { get; set; }
        public virtual ICollection<BalkonFilesi>? BalkonFilesis { get; set; }
        public virtual ICollection<BanyoTadilat>? BanyoTadilats { get; set; }
        public virtual ICollection<BinaGuclendirme>? BinaGuclendirmes { get; set; }
        public virtual ICollection<BoyaBadana>? BoyaBadanas { get; set; }
        public virtual ICollection<CamBalkon>? CamBalkons { get; set; }
        public virtual ICollection<EvTadilat>? EvTadilats { get; set; }
        public virtual ICollection<Mantolama>? Mantolamas { get; set; }
        public virtual ICollection<MutfakDolabiYapimi>? MutfakDolabiYapimis { get; set; }

    }
}
