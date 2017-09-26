using System;
using System.Collections.Generic;
using System.Linq;

namespace MaVoiture.Model
{
    public class Reparation
    {
        #region Constructeur
        public Reparation(DateTime? date = null, string lieu = null)
        {
            Date = date;
            Lieu = lieu;
        }
        #endregion Constructeur

        #region Propriétés publiques
        public DateTime? Date { get; set; }

        public string Lieu { get; set; }

        public List<LigneReparation> ListeLignesReparation { get; set; }
        #endregion Propriétés publiques

        #region Méthodes publiques
        public bool AjouterLigneReparation(LigneReparation ligneReparation)
        {
            if (ligneReparation != null)
            {
                if (ListeLignesReparation == null)
                {
                    ListeLignesReparation = new List<LigneReparation>();
                }

                ListeLignesReparation.Add(ligneReparation);

                return true;
            }

            return false;
        }

        public bool? SupprimerLigneReparation(LigneReparation ligneReparation)
        {
            if (ligneReparation != null && ListeLignesReparation.Any())
            {
                return ListeLignesReparation.Remove(ligneReparation);
            }

            return null;
        }
        #endregion Méthodes publiques
    }
}
