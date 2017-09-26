using System.Collections.Generic;
using MaVoiture.Model;

namespace MaVoiture.Dummy
{
    public class DummyData
    {
        static DummyData()
        {
            listeVoiture = new List<Voiture>();

            Voiture voitureAxel = new Voiture("AV-777-VT", "Tuture", "Grise", "Renault", "Laguna");
            Voiture voitureMathilde = new Voiture("MB-126-AL", "Titine", "Noire", "Fiat", "500");

            listeVoiture.Add(voitureAxel);
            listeVoiture.Add(voitureMathilde);
        }

        static List<Voiture> listeVoiture;

        public static List<Voiture> GetVoitures()
        {
            return listeVoiture;
        }
    }
}
