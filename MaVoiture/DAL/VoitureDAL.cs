using System.Collections.Generic;
using MaVoiture.Dummy;
using MaVoiture.Model;

namespace MaVoiture.DAL
{
    public class VoitureDAL
    {
        public VoitureDAL()
        {
        }

        public static List<Voiture> GetVoitures()
        {
            return DummyData.GetVoitures();
        }
    }
}
