using SQLite;
using System;

namespace Shared.Models
{
    class Reparation
    {
        [PrimaryKey, AutoIncrement]
        public int IdReparation { get; set; }
        public DateTime Date { get; set; }
        public decimal Prix { get; set; }
        public string Lieu { get; set; }
        public int Voiture_IdVoiture { get; set; }
    }
}
