using Entities.Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _manager;

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.Product.GetAllProducts(false);
            return View(model);
        }

        public IActionResult Get(int Id)
        {
            var model = _manager.Product.GetOneProduct(Id, false);
            return View(model);
        }
    }
}