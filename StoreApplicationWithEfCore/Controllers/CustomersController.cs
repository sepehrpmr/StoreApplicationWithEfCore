﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreApplicationWithEfCore.Models.Services.GetCustomerList;
using StoreApplicationWithEfCore.Models.Services.GetProductList;

namespace StoreApplicationWithEfCore.Controllers
{
    public class CustomersController : Controller
    {
        private readonly IGetCustomerListService _getCustomerListService;
        



        public CustomersController(IGetCustomerListService getCustomerListService)
        {
            _getCustomerListService = getCustomerListService;
        }
        // GET: CustomersController
        public ActionResult Index()
        {
            
            return View(_getCustomerListService.Execute());
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
