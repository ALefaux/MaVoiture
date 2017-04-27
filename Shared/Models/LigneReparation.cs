using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    class LigneReparation
    {
        public int IdLigneReparation { get; set; }
        public string Nom { get; set; }
        public decimal PrixUnite { get; set; }
        public int Unites { get; set; }
        public decimal PrixTotal { get; set; }
        public int Reparation_IdReparation { get; set; }
    }
}
