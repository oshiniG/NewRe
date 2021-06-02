using AutoElectronic.Application.Interfaces;
using AutoElectronic.Application.ViewModels;
using AutoElectronic.Infrastructure.IOC;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoElectronic.MvcUi.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        private readonly ILogger _logger;
        public ItemController(IItemService itemService, ILogger logger)
        {
            _itemService = itemService;
            _logger = logger;
        }

        [Authorize]
        public ActionResult Index()
        {
            ItemListViewModel model = _itemService.GetItemList();
            return View(model);
        }

        [Authorize]
        public ActionResult Details(int id)
        {
            ItemViewModel model = _itemService.GetItem(id);
            return View(model);
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            ItemViewModel model = _itemService.GetItem(id);
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Edit(ItemViewModel item)
        {
            if (ModelState.IsValid)
            {
                bool result = _itemService.EditItem(item);
                if (result)
                {
                    TempData["EditMessage"] = "Edited Successfully!";
                    return View();
                }
                else
                {
                    TempData["EditMessage"] = "Error , Please contact administrator";
                }
            }
            return View();
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(ItemViewModel item)
        {
            if (ModelState.IsValid)
            {
                bool result = _itemService.AddItem(item);
                if (result)
                {
                    TempData["CreateMessage"] = "Added Successfully!";
                    ModelState.Clear();
                    return View();
                }
                else
                {
                    TempData["CreateMessage"] = "Error , Please contact administrator";
                }
            }
            return View();
        }


        [Authorize]
        public ActionResult Delete(int id)
        {
            ItemViewModel model = _itemService.GetItem(id);
            return View(model);
        }

        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                bool result = _itemService.DeleteItem(id);
                if (result)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

    }
}
