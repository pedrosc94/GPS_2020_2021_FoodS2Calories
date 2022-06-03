using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLite;

//Tste Branch

namespace FoodS2Calories
{
    public class FoodItemDatabase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public FoodItemDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(FoodItem).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(FoodItem)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<FoodItem>> GetItemsAsync()
        {
            return Database.Table<FoodItem>().ToListAsync();
        }

        public Task<List<FoodItem>> GetItemsNotDoneAsync()
        {
            return Database.QueryAsync<FoodItem>("SELECT * FROM [FoodItem] WHERE [Done] = 0 ORDER BY Name ASC;");
        }


        public Task<List<FoodItem>> ResetItemsAsync()
        {

            return Database.QueryAsync<FoodItem>("DELETE FROM FoodItem;");



        }


        public Task<List<FoodItem>> CalcItemDoneAsync()
        {

            return Database.QueryAsync<FoodItem>("SELECT * FROM [FoodItem] WHERE [Done] = 1 ORDER BY Name ASC;");



        }



        public Task<List<FoodItem>> GetItemsDoneAsync()
        {
            return Database.QueryAsync<FoodItem>("SELECT * FROM [FoodItem] WHERE [Done] = 1 ORDER BY Name ASC;");
        }



       // public Task<FoodItem> GetItemAsync(int id)
       // {
       //     return Database.Table<FoodItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
      //  }


        public Task<List<FoodItem>> GetItemAsync(int id)
        {
            return Database.QueryAsync<FoodItem>("SELECT * FROM [FoodItem] WHERE [Exist] = 1 ORDER BY Name ASC;");
        }





        public Task<int> SaveItemAsync(FoodItem item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(FoodItem item)
        {
            return Database.DeleteAsync(item);
        }
    }
}

