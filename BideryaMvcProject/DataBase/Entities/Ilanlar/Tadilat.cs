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
        public virtual ICollection<CatiTadilati>? CatiTadilatis { get; set; }
        public virtual ICollection<CelikEvYapimi>? CelikEvYapimis { get; set; }
        public virtual ICollection<CelikKapi>? CelikKapis { get; set; }
        public virtual ICollection<DemirKaynak>? DemirKaynaks { get; set; }
        public virtual ICollection<DepremTesti>? DepremTestis { get; set; }
        public virtual ICollection<DogalgazTesisatiVeProjesi>? DogalgazTesisatiVeProjesis { get; set; }
        public virtual ICollection<DolapYapimi>? DolapYapimis { get; set; }
        public virtual ICollection<Dusakabin>? Dusakabins { get; set; }
        public virtual ICollection<DuvarKagidiIsleri>? DuvarKagidiIsleris { get; set; }
        public virtual ICollection<EpoksiZeminKaplama>? EpoksiZeminKaplamas { get; set; }
        public virtual ICollection<EvDekorasyon>? EvDekorasyons { get; set; }
        public virtual ICollection<EvTadilat>? EvTadilats { get; set; }
        public virtual ICollection<FayansDoseme>? FayansDosemes { get; set; }
        public virtual ICollection<GunesEnerjisi>? GunesEnerjisis { get; set; }
        public virtual ICollection<HavuzYapimi>? HavuzYapimis { get; set; }
        public virtual ICollection<HazirRuloCim>? HazirRuloCims { get; set; }
        public virtual ICollection<KabaInsaat>? KabaInsaats { get; set; }
        public virtual ICollection<KapiPencereSinekligi>? KapiPencereSinekligis { get; set; }
        public virtual ICollection<KoltukDoseme>? KoltukDosemes { get; set; }
        public virtual ICollection<LaminatParkeDoseme>? LaminatParkeDosemes { get; set; }
        public virtual ICollection<Mantolama>? Mantolamas { get; set; }
        public virtual ICollection<MezarYapimi>? MezarYapimis { get; set; }
        public virtual ICollection<MimariProjeCizimi>? MimariProjeCizimis { get; set; }
        public virtual ICollection<MobilyaBoyama>? MobilyaBoyamas { get; set; }
        public virtual ICollection<MutfakDolabiYapimi>? MutfakDolabiYapimis { get; set; }
        public virtual ICollection<MutfakTadilat>? MutfakTadilats { get; set; }
        public virtual ICollection<MutfakTezgahi>? MutfakTezgahis { get; set; }
        public virtual ICollection<OtomatikKepenk>? OtomatikKepenks { get; set; }
        public virtual ICollection<OzelMobilyaYapimi>? OzelMobilyaYapimis { get; set; }
        public virtual ICollection<Panjur>? Panjurs { get; set; }
        public virtual ICollection<ParkeSistreCila>? ParkeSistreCilas { get; set; }
        public virtual ICollection<ParkeTasiDoseme>? ParkeTasiDosemes { get; set; }
        public virtual ICollection<PrefabrikEvYapimi>? PrefabrikEvYapimis { get; set; }
        public virtual ICollection<PVCKapiPencereBalkon>? PVCKapiPencereBalkons { get; set; }
        public virtual ICollection<SeramikDoseme>? SeramikDosemes { get; set; }
        public virtual ICollection<SesYalitimi>? SesYalitimis { get; set; }
        public virtual ICollection<StorPerde>? StorPerdes { get; set; }
        public virtual ICollection<SupurgelikMontaji>? SupurgelikMontajis { get; set; }
        public virtual ICollection<SurguluKapi>? SurguluKapis { get; set; }


        public virtual ICollection<SuYalitimi>? SuYalitimis { get; set; }
        public virtual ICollection<TelOrguCiti>? TelOrguCitis { get; set; }
        public virtual ICollection<TenteBrandaTadilatVeDekorasyon>? TenteBrandaTadilatVeDekorasyons { get; set; }
       



        
        

    }
}
