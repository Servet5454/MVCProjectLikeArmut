﻿using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class BosEvTemizlik
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik);
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.BosEvTemizligi);
        public string? Aciklama { get; set; }
        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        public string? Il { get; set; }
        public string? Ilce { get; set; }

       
        public DateTime YayinlanmaTarihi { get; set; } = DateTime.Now;

        public string? OdaSayisi { get; set; }
        public int BanyoSayisi { get; set; }
        public string? EvinDurumu { get; set; }
        private string? IlanBaslik { get; set; } = "Boş Ev Temizliği";

        public Ilan? Ilan { get; set; }

    }
}
