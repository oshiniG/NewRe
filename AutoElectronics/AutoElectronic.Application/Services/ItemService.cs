using AutoElectronic.Application.Interfaces;
using AutoElectronic.Application.ViewModels;
using AutoElectronic.Domain.Interfaces;
using AutoElectronic.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoElectronic.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public ItemService(IItemRepository itemRepository, IMapper mapper) 
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public bool AddItem(ItemViewModel item)
        {
            var mappedItem = _mapper.Map<Item>(item);
            bool result = _itemRepository.AddItem(mappedItem);
            return result;
        }

        public bool DeleteItem(int id)
        {
            bool result = _itemRepository.DeleteItem(id);
            return result;
        }

        public bool EditItem(ItemViewModel item)
        {
            var mappedItem = _mapper.Map<Item>(item);
            bool result = _itemRepository.EditItem(mappedItem);
            return result;
        }

        public ItemViewModel GetItem(int id)
        {
            Item item = _itemRepository.GetItem(id);
            return _mapper.Map<ItemViewModel>(item);
        }

        public ItemListViewModel GetItemList()
        {
            IEnumerable<Item> itemList = _itemRepository.GetItemList();
            return new ItemListViewModel()
            {
                Itemlist = _mapper.Map<IEnumerable<ItemViewModel>>(itemList)
            };
        }
    }
}