using Shared.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DAL
{
    class ReparationDAL
    {
        private string CreateDatabase(string path)
        {
            try
            {
                var connexion = new SQLiteConnection(path);
                connexion.CreateTable<Reparation>();

                return "Database created";
            }
            catch (SQLiteException se)
            {
                return se.Message;
            }
        }

        private string InsertUpdateData(Reparation reparation, string path)
        {
            try
            {
                var db = new SQLiteAsyncConnection(path);
                if (db.InsertAsync(reparation).Result != 0)
                {
                    db.UpdateAsync(reparation);
                    return "Single data file updated";
                }

                return "Single data file inserted";
            }
            catch (SQLiteException se)
            {
                // Afficher exception personnalisée
            }
        }

        private Reparation SelectData(int id, string path)
        {
            try
            {
                var db = new SQLiteConnection(path);
                Reparation reparation = db.Query<Reparation>("SELECT * FROM Reparation WHERE IdReparation = " + id).FirstOrDefault();

                return reparation;
            }
            catch (SQLiteException se)
            {
                // Afficher exception personnalisée
            }
        }

        private List<Reparation> SelectAllReparation(string path)
        {
            try
            {
                var db = new SQLiteConnection(path);
                List<Reparation> listReparation = db.Query<Reparation>("SELECT * FROM Reparation").ToList();

                return listReparation;
            }catch(SQLiteException se)
            {
                // Afficher exception personnalisée
            }
        }
    }
}
