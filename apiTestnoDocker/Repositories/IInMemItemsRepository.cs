using apiTestnoDocker.Entities;
using System;
using System.Collections.Generic;

namespace apiTestnoDocker.Repositories
{
    public interface IInMemItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);
    }
}