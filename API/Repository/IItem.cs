using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Repository
{
    public interface IItem
    {
        Item GetById(int id);
        IEnumerable<Item> GetAllItems();
        Task Create(Item item);
        Task Delete(Item item);
        Task DeleteById(int id);
        Task UpdatePrice(int id , int price);
        Task UpdateName(int id, string name);

    }
}