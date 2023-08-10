﻿using BideryaMvcProject.DataBase.Entities.Ilanlar;
using System.ComponentModel.DataAnnotations.Schema;

namespace BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon
{
    public class EvTadilat
    {
        public int Id { get; set; }
        [ForeignKey(nameof(IlanId))]
        public int IlanId { get; set; }
       
        public string? TadilatTipi { get; set; }
        public string? BoyaBadana { get; set; }
        public string? Mutfak { get; set; }
        public string? Banyo { get; set; }
        public string? KapıPencere { get; set; }
        public string? FayansDoseme { get; set; }
        public string? ParkeLaminant { get; set; }
        public string? CamBalkon { get; set; }
        public int MetreKare { get; set; }
        public string? TadilatIsTuru { get; set; }
        public string? TadilatOdaları { get; set; }
        public string? EvinDurumu { get; set; }
        public string? MalzemeKalitesi { get; set; }
        public string? Aciklama { get; set; }
        public string? Diger { get; set; }
        public virtual Tadilat? Tadilat { get; set; }

    }
}
