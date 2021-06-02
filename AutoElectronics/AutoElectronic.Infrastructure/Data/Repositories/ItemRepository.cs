using AutoElectronic.Domain.Interfaces;
using AutoElectronic.Domain.Models;
using AutoElectronic.Infrastructure.IOC;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoElectronic.Infrastructure.Data.Repositories
{
    public class ItemRepository : IItemRepository
    {
        #region Private Properties
        private readonly AutoElectronicDbContext _context;
        private ILogger _logger = null;
        #endregion

        public ItemRepository(AutoElectronicDbContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// This method is for edit item 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool EditItem(Item item)
        {
            try
            {
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Logger.LogError(_logger, "Error occured while editing the item",ex);
                return false;
            }
        }

        /// <summary>
        /// This method is for add item to the item table
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddItem(Item item)
        {
            try
            {
                _context.Item.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Logger.LogError(_logger, "Error occured while adding the item", ex);
                return false;
            }
        }
        public Item GetItem(int id)
        {
            return _context.Item.Find(id);
        }

        public IEnumerable<Item> GetItemList()
        {
            return _context.Item;
        }

        /// <summary>
        /// This method is to delete item from the context
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteItem(int id)
        {
            try
            {
                Item item = _context.Item.Find(id);
                _context.Item.Remove(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Logger.LogError(_logger, "Error occured while deleting the item", ex);
                return false;

            }
        }
    }
}
