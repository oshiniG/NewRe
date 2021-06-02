using AutoElectronic.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoElectronic.Domain.Interfaces
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetItemList();
        Item GetItem(int id);
        bool EditItem(Item item);
        bool AddItem(Item item);
        bool DeleteItem(int id);
    }
}
