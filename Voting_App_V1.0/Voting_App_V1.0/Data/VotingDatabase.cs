using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Voting_App_V1_0.Models;
using System.Text;

namespace Voting_App_V1_0.Data
{
    public class VotingDatabase
    {
        private readonly SQLiteAsyncConnection database;

        public VotingDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<VotingAppV10>().Wait();
        }

        public Task<List<VotingAppV10>> GetVotesAsync()
        {
            return database.Table<VotingAppV10>().ToListAsync();
        }

        public Task<VotingAppV10> GetVoteAsync(int id)
        {
            return database.Table<VotingAppV10>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(VotingAppV10 va)
        {
            if (va.ID != 0)
            {
                return database.UpdateAsync(va);
            }
            else
            {
                return database.InsertAsync(va);
            }
        }

        public Task<int> DeleteNoteAsync(VotingAppV10 va)
        {
            return database.DeleteAsync(va);
        }
    }
}
