using SQLite;

namespace Shared.Models
{
	public class Voiture
	{
		[PrimaryKey, AutoIncrement]
		public int IdVoiture { get; set; }
		public string Nom { get; set; }
		public string Plaque { get; set; }
		public string Marque { get; set; }
		public string Modele { get; set; }
	}
}
