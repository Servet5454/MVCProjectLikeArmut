﻿using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik
{
    public class ApartmanTemizlik
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik);
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.ApartmanTemizligi);
        public string? IlanBaslik { get; set; } = "Apartman Temizlik";
        public bool Aktifmi { get; set; } = false;
        public int TeklifSayisi { get; set; } = 0;
        
        public DateTime YayinlanmaTarihi { get; set; } = DateTime.Now;
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Aciklama { get; set; }






        public int DaireSayisi { get; set; }
        public bool CopToplama { get; set; }
        
       
        


        public Ilan? Ilan { get; set; }
    }
}
