using AutoElectronic.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoElectronic.Application.Interfaces
{
    public interface IItemService
    {
        ItemListViewModel GetItemList();
        ItemViewModel GetItem(int id);
        bool EditItem(ItemViewModel item);
        bool AddItem(ItemViewModel item);
        bool DeleteItem(int id);

    }
}
