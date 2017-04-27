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
                // Montrer une exception
                return se.Message;
            }
        }
    }
}
