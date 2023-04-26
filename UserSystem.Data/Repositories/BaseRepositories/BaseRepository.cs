using LoginSystem.Core.Users.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSystem.Data.Repositories.BaseRepositories
{
    public abstract class BaseRepository<T> where T : BaseModel
    {
        private static readonly List<T> _items = new List<T>();

        public static async Task CreateAsync(T model)
        {
            _items.Add(model);
        }

        public static async Task<T> GetAsync(int id, Predicate<T> func)
        {
            return _items.Find(func);
        }

        public static List<T> GetAllAsync()
        {
            return _items;
        }

        public static async Task DeleteAsync(T model)
        {
            foreach ( T item in _items)
            {
                if (item == model)
                {
                   _items.Remove(item);
                }
            }
        }
          

    }
}

       




    