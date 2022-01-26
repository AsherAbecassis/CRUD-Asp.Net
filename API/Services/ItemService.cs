using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using API.Repository;

namespace API.Services
{
    public class ItemService : IItem
    {
        private readonly ApplicationDbContext _db;

        public ItemService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(Item item)
        {
            await _db.Items.AddAsync(item);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Item item)
        {
           _db.Items.Remove(item);
           await _db.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {
            var item = _db.Items.FirstOrDefault(i => i.ItemId == id);
            if(item!=null)
            {
                await Delete(item);
            }
            
        }
        public  IEnumerable<Item> GetAllItems()
        {
            var model =  _db.Items;
            return model;

        }

        public Item GetById(int id)
        {
            Item item = _db.Items.FirstOrDefault(i => i.ItemId == id);
            if( item!= null)
            {
                return item;
            }
            return null;
        }

        public Task UpdateName(int id, string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePrice(int id, int price)
        {
            throw new NotImplementedException();
        }
    }
}