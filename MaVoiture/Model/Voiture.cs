using System.Collections.Generic;
using System.Linq;

namespace MaVoiture.Model
{
    public class Voiture
    {
        #region Constructeur
        public Voiture(string plaque = null, string nom = null, string couleur = null, string marque = null, string modele = null)
        {
            Plaque = plaque;
            Marque = marque;
            Modele = modele;
            Couleur = couleur;
            Nom = nom;
        }
        #endregion Constructeur

        #region Propriétés publiques
        public string Plaque { get; set; }

        public string Marque { get; set; }

        public string Modele { get; set; }

        public string Couleur { get; set; }

        public string Nom { get; set; }

        public List<Consommation> ListeConsommations { get; set; }

        public List<Reparation> ListeReparation { get; set; }
        #endregion Propriétés publiques

        #region Méthodes publiques
        public bool AjouterConsommation(Consommation consommation)
        {
            if (consommation != null)
            {
                if (ListeConsommations == null)
                {
                    ListeConsommations = new List<Consommation>();
                }

                ListeConsommations.Add(consommation);

                return true;
            }

            return false;
        }

        public bool? SupprimerConsommation(Consommation consommation)
        {
            if (consommation != null && ListeConsommations.Any())
            {
                return ListeConsommations.Remove(consommation);
            }

            return false;
        }

        public bool AjouterReparation(Reparation reparation)
        {
            if (reparation != null)
            {
                if (ListeReparation == null)
                {
                    ListeReparation = new List<Reparation>();
                }

                ListeReparation.Add(reparation);

                return true;
            }

            return false;
        }

        public bool? SupprimerReparation(Reparation reparation)
        {
            if (reparation != null && ListeReparation.Any())
            {
                return ListeReparation.Remove(reparation);
            }

            return null;
        }
        #endregion Méthodes publiques
    }
}
