using BusiniessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.Controllers
{
    public class CartController : Controller
    {
        CartManager cartManager = new CartManager(new EfCartDal());
        public IActionResult Index()
        {
            var values = cartManager.TGetList();
            return View(values);
        }
    }
}
