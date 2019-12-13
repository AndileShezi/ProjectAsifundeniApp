using Bashana.Services.Interface;
using NguniLearning2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Bashana.Services
{
    class UserDatabase : IDatabase
    {
        private SQLiteAsyncConnection database;

        public UserDatabase()
        {
            string dbPath = GetDbPath();

            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<UserDetails>().Wait();


        }
        private string GetDbPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "products.db3");
        }

        public Task<int> UpdateProduct(UserDetails userDetails)
        {

            if (userDetails.Id != 0)
            {
                return database.UpdateAsync(userDetails);
            }
            else
            {
                return database.InsertAsync(userDetails);
            }


        }

        public async Task<List<UserDetails>> GetSortedData()
        {
            return await database.Table<UserDetails>().OrderByDescending(o => o.Id).ToListAsync();
        }

    }
}
