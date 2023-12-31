﻿using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class MantolamaViewModel :IlanAdresGenelBilgi
    {
        
        public int BinaKatSayisi { get; set; }
        public int BinaCepheUzunluk { get; set; }
        public int KisaCepheUzunluk { get; set; }
        public int CepheSayisi { get; set; }
        public string? Ozellikler { get; set; }
        public string? MarkaTercih { get; set; }
        public int BalkonTipi { get; set; }
        public string? IlanBaslik { get; set; } = "Mantolama";

    }
}
