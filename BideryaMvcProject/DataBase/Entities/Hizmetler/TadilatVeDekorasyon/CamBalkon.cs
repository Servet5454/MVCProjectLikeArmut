﻿using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Helper.IlanHelpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon
{
    public class CamBalkon
    {
        public int Id { get; set; }
        public int TadilatId { get; set; }
        public int IlanKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon);
        public int IlanAltKategoriId { get; set; } = Convert.ToInt32(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.CamBalkon);
        public string? IlanBaslik { get; set; } = "Cam Balkon";



        public string? Aciklama { get; set; }


        public virtual Tadilat? Tadilat { get; set; }


    }
}
