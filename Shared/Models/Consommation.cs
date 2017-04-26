using System;
using SQLite;

namespace Shared.Models
{
	public class Consommation
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public DateTime Date { get; set; }
		public decimal Prix { get; set; }
		public decimal PrixLitre { get; set; }
		public decimal DistanceGenerale { get; set; }
		public decimal DistancePartielle { get; set; }
		public decimal CarburantUtilise { get; set; }
		public decimal ConsommationMoyenne { get; set; }
		public decimal DistanceParcourue { get; set; }
		public string VitesseMoyenne { get; set; }
		public string InformationsComplementaires { get; set; }
	}
}
