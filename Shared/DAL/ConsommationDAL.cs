using SQLite;
using System.Collections.Generic;
using Shared.Models;
using System;

namespace Shared.DAL
{
	public static class ConsommationDAL
	{
		private static string CreateDatabase(string path)
		{
			try
			{
				var connexion = new SQLiteAsyncConnection(path);
				connexion.CreateTableAsync<Consommation>();

				return "Database created";
			}
			catch (SQLiteException se)
			{
				return se.Message;
			}
		}

		private static string InsertUpdateData(Consommation pConsommation, string path)
		{
			try
			{
				var db = new SQLiteAsyncConnection(path);
				if (db.InsertAsync(pConsommation).Result != 0)
					db.UpdateAsync(pConsommation);

				return "Single data file inserted or updated";
			}
			catch (SQLiteException se)
			{
				throw new Exception("La donnée n'a pas pû être ajoutée.", se);
			}
		}

		private static Consommation SelectData(int id, string path)
		{
			try
			{
				var db = new SQLiteAsyncConnection(path);
				var consommation = new Consommation();
				consommation = db.QueryAsync<Consommation>("SELECT * FROM Consommation WHERE ID = " + id).Result[0];

				return consommation;
			}
			catch (SQLiteException se)
			{
				throw new Exception("La donnée n'a pas pû être sélectionnée.",se);
			}
		}

		private static List<Consommation> SelectAllData(string path)
		{
			try
			{
				var db = new SQLiteAsyncConnection(path);
				var consommations = new List<Consommation>();
				consommations = db.QueryAsync<Consommation>("SELECT * FROM Consommation").Result;

				return consommations;
			}
			catch (SQLiteException se)
			{
				throw new Exception("Les données n'ont pas pû être téléchargées.", se);
			}
		}

		private static int DeleteData(int id, string path)
		{
			try
			{
				var db = new SQLiteAsyncConnection(path);
				int result = db.ExecuteScalarAsync<int>("DELETE FROM Consommation WHERE id = " + id).Result;

				return result;
			}
			catch (SQLiteException se)
			{
				throw new Exception("La donnée n'a pas pû être supprimée.", se);
			}
		}

		private static int FindNumberRecords(string path)
		{
			try
			{
				var db = new SQLiteAsyncConnection(path);
				var count = db.ExecuteScalarAsync<int>("SELECT Count(*) FROM Consommation").Result;

				return count;
			}
			catch (SQLiteException se)
			{
				throw new Exception("Le nombre de données dans la base n'a pas pû être trouvé.", se);
			}
		}
	}
}
