﻿using BideryaMvcProject.DataBase.Entities.Ilanlar;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class KoltukTemizlik
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanAltKategoriId))]
        public int IlanAltKategoriId { get; set; }
        public int IlanId { get; set; }
        public int TekliKoltukSayisi { get; set; }
        public int IkiliKoltukSayisi { get; set; }
        public int UcluKoltukSayisi { get; set; }
        public int LKoltukSayisi { get; set; }
        public int SandalyeSayisi { get; set; }
        public int MinderSayisi { get; set; }
        public int TekliYatakSayisi { get; set; }
        public int CiftKisilikYatakSayisi { get; set; }
        public int TeklifSayisi { get; set; }
        public string? Aciklama { get; set; }

        public virtual Ilan? Ilan { get; set; }

    }
}
