using SQLite;

namespace Shared.Models
{
    class LigneReparation
    {
        [PrimaryKey, AutoIncrement]
        public int IdLigneReparation { get; set; }
        public string Nom { get; set; }
        public decimal PrixUnite { get; set; }
        public int Unites { get; set; }
        public decimal PrixTotal { get; set; }
        public int Reparation_IdReparation { get; set; }
    }
}
