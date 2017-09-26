namespace MaVoiture.Model
{
    public class LigneReparation
    {
        #region Constructeur
        public LigneReparation(string produit = null, int? quantite = null, decimal? prixUnitaire = null, decimal? prixTotal = null)
        {
            Produit = produit;
            Quantite = quantite;
            PrixUnitaire = prixUnitaire;
            PrixTotal = prixTotal;
        }
        #endregion Constructeur

        #region Propriétés publiques
        public string Produit { get; set; }

        public int? Quantite { get; set; }

        public decimal? PrixUnitaire { get; set; }

        public decimal? PrixTotal { get; set; }
        #endregion Propriétés publiques
    }
}
