using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreApplicationWithEfCore.Models.Services.GetProductList;

namespace StoreApplicationWithEfCore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IGetProductListService _getProductListService;

        public ProductsController(IGetProductListService getProductListService)
        {
            _getProductListService = getProductListService;
        }

        // GET: Products
        public IActionResult Index()
        {
            var result = _getProductListService.ExecuteGetProductList();
            return View(result);
        }

        // GET: Products/Details/5
        public IActionResult Details(int id)
        {
            return View(); // You can add IGetProductDetailsService for this
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                // You can call ICreateProductService here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public IActionResult Edit(int id)
        {
            return View(); // You can add IGetProductDetailsService to pre-fill this
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // You can call IEditProductService here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public IActionResult Delete(int id)
        {
            return View(); // Optional: Load product to confirm delete
        }

        // POST: Products/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // You can call IDeleteProductService here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
