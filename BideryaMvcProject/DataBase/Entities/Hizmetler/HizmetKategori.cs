using BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon;
using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler
{
    public class HizmetKategori
    {
        public HizmetKategori()
        {
            HizmetAltKategoris = new HashSet<HizmetAltKategori>();
        }
        public int Id { get; set; }
        [ForeignKey(name: "HizmetVerenId")]
        public int HizmetVerenId { get; set; }
        public int KategoriId { get; set; }

        public HizmetVeren? HizmetVeren { get; set; }
        public ICollection<HizmetAltKategori>? HizmetAltKategoris { get; set; }
    }
}
