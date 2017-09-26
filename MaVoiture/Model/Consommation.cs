using System;
namespace MaVoiture.Model
{
    public class Consommation
    {
        #region Constructeur
        public Consommation(decimal? prixTotal = null, decimal? prixDuLitre = null, decimal? litres = null, DateTime? date = null, string lieu = null)
        {
            PrixTotal = prixTotal;
            PrixDuLitre = prixDuLitre;
            Litres = litres;
            Date = date;
            Lieu = lieu;
        }
        #endregion Constructeur

        #region Propriétés publiques
        public decimal? PrixTotal { get; set; }

        public decimal? PrixDuLitre { get; set; }

        public decimal? Litres { get; set; }

        public DateTime? Date { get; set; }

        public string Lieu { get; set; }
        #endregion Propriétés publiques
    }
}
