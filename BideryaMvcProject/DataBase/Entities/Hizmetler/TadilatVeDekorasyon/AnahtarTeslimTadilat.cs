﻿using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon
{
    public class AnahtarTeslimTadilat
    {
        public int Id { get; set; }
        public int TadilatId { get; set; }
        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon);
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.AnahtarTeslimTadilat);
        public string? IlanBaslik { get; set; } = "Anahtar Teslim Tadilat";
        public string? Aciklama { get; set; }


        public string? Tur { get; set; }
        public string? Metrekare { get; set; }
        public string? Malzeme { get; set; }



        public virtual Tadilat? Tadilat { get; set; }
    }
}
