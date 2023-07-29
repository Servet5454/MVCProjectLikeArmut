﻿using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class EvTemizlikViewModel
    {
        public int Id { get; set; }
        public int TemizlikAnaId { get; set; }
        public bool Aktifmi { get; set; } = false;

        //public string? OdaSayisi { get; set; }
        //public int BanyoSayisi { get; set; }
        //public int BalkonSayisi { get; set; }
        //public float CalismaSuresi { get; set; }
        //public string? HayvanVarmi { get; set; }
        //public string? Aciklama { get; set; }


        public TemizlikAna? TemizlikAna { get; set; }
    }
}