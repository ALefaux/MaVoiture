using SQLite;
using System.Collections.Generic;
using Shared.Models;

namespace Shared.DAL
{
	public class VoitureDAL
	{
		private string CreateDatabase(string path)
		{
			try
			{
				var connexion = new SQLiteAsyncConnection(path);
				connexion.CreateTableAsync<Voiture>();

				return "Database created";
			}
			catch (SQLiteException se)
			{
				return se.Message;
			}
		}

		private string InsertUpdateData(Voiture voiture, string path)
		{
			try
			{
				var db = new SQLiteAsyncConnection(path);
				if (db.InsertAsync(voiture).Result != 0)
					db.UpdateAsync(voiture);

				return "Single data file inserted or updated";
			}
			catch (SQLiteException se)
			{
				// Montrer une exception
				return se.Message;
			}
		}

		private Voiture SelectData(int id, string path)
		{
			try
			{
				var db = new SQLiteAsyncConnection(path);
				Voiture voiture = new Voiture();
				voiture = db.QueryAsync<Voiture>("SELECT * FROM Voiture WHERE ID = " + id).Result[0];

				return voiture;
			}
			catch (SQLiteException se)
			{
				// Montrer une exception
				return null;
			}
		}

		private List<Voiture> SelectAllData(string path)
		{
			try
			{
				var db = new SQLiteAsyncConnection(path);
				List<Voiture> voiture = new List<Voiture>();
				voiture = db.QueryAsync<Voiture>("SELECT * FROM Voiture").Result;

				return voiture;
			}
			catch (SQLiteException se)
			{
				// Montrer une exception
				return null;
			}
		}

		private int FindNumberRecords(string path)
		{
			try
			{
				var db = new SQLiteAsyncConnection(path);
				var count = db.ExecuteScalarAsync<int>("SELECT Count(*) FROM Voiture").Result;

				return count;
			}
			catch (SQLiteException se)
			{
				// Montrer une exception
				return -1;
			}
		}
	}
}
