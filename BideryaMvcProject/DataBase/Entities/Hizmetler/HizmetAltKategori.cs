using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler
{
    public class HizmetAltKategori
    {
        public int Id { get; set; }
        public int HizmetVerenId { get; set; }
        public int HizmetKategoriId { get; set; }   
        public int HizmetVerenName { get; set; }
        
        
        

        #region Temizlik
        public bool AracYikamaIslemi { get; set; } = false;
        public bool EvTemizlikIslemi { get; set; } = false;
        public bool IlaclamaIslemi { get; set; } = false;
        public bool KoltukTemizlikIslemi { get; set; } = false;

        #endregion

        #region TadilatDekorasyon
        public bool CamBalkon { get; set; } = false;
        public bool EvTadilat { get; set; } = false;
        public bool Mantolama { get; set; } = false;
        public bool MutfakDolabiYapimi { get; set; } = false;

        #endregion

        #region Organizasyon

        #endregion

    }
}
