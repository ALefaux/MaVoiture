using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    class Reparation
    {
        public int IdReparation { get; set; }
        public DateTime Date { get; set; }
        public decimal Prix { get; set; }
        public string Lieu { get; set; }
    }
}
