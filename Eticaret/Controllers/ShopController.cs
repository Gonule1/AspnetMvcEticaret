using BusiniessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.Controllers
{
    public class ShopController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }
        public IActionResult ProductDetails(int Id)
        { var values=productManager.GetProductById(Id);
            return View(values);

        }
    }
}
