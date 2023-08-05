﻿namespace BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri
{
    public class IlanAdresGenelBilgi
    {
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? AdresGenel { get; set; }
        
        public int TeklifSayisi { get; set; } = 0;        
        public string? Aciklama { get; set; } 
    }
}
