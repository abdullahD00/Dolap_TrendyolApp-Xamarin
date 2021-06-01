using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dolap.Users;
using SQLite;
using Dolap.Models;

namespace Dolap.Services
{
  public  class DBService
    {

        private SQLiteAsyncConnection database;

        public SQLiteAsyncConnection Database { get => database; set => database = value; }
   
            
        public DBService(string path)
        {
            Database = new SQLiteAsyncConnection(path);
            Database.CreateTableAsync<USER>();
            Database.CreateTableAsync<AnaSayfaRandomUrunler>();
        }
    
        public Task<USER> GetUserByName(string username)
        {
            return Database.Table<USER>().Where(İ => İ.Equals(username)).FirstOrDefaultAsync();
        }

        public  Task<int> addUser(USER user)
        {
            if (user.USERID==0)
            {
                return Database.InsertAsync(user);
            }
            else
            {
                return Database.UpdateAsync(user);
            }
        }


        public Task<USER> LoginFunction(string username, string password)
        {
            return Database.Table<USER>().Where(x => x.NAME.Equals(username) && x.PASSWORD.Equals(password)).FirstOrDefaultAsync();
        }
       
         
        public Task<int> Sepeteekle(AnaSayfaRandomUrunler randomurunler)
        {
            return Database.InsertAsync(randomurunler);
        }
    
    
    }
}
