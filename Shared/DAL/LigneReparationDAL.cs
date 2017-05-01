using Shared.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DAL
{
    class LigneReparationDAL
    {
        private string CreateDatabase(string path)
        {
            try
            {
                var connexion = new SQLiteConnection(path);
                connexion.CreateTable<LigneReparation>();

                return "Database created";
            }catch(SQLiteException se)
            {
                throw;
            }
        }

        private string InsertUpdateData(LigneReparation ligneReparation, string path)
        {
            try
            {
                var db = new SQLiteConnection(path);
                if (db.Insert(ligneReparation) != 0)
                    db.Update(ligneReparation);

                return "Single data file inserted or updated";
            }
            catch (SQLiteException se)
            {

                throw;
            }
        }

        private LigneReparation SelectData(int id, string path)
        {
            try
            {
                var db = new SQLiteConnection(path);

                return db.Query<LigneReparation>("SELECT * FROM LigneReparation WHERE idLigneReparation = " + id).First();
            }
            catch (SQLiteException se)
            {

                throw;
            }
        }

        private List<LigneReparation> SelectAllData(string path)
        {

            try
            {
                var db = new SQLiteConnection(path);

                return db.Query<LigneReparation>("SELECT * FROM LigneReparation");
            }catch(SQLiteException se)
            {
                throw;
            }
        }

        private int DeleteData(int id, string path)
        {
            try
            {
                var db = new SQLiteConnection(path);

                return db.ExecuteScalar<int>("DELETE FROM LigneReparation WHERE IdLigneReparation = " + id);
            }
            catch (SQLiteException se)
            {

                throw;
            }
        }

        private int FindNumberRecords(string path)
        {
            try
            {
                var db = new SQLiteConnection(path);

                return db.ExecuteScalar<int>("SELECT Count(*) FROM LigneReparation");
            }
            catch (SQLiteException se)
            {
                throw;
            }
        }
    }
}
