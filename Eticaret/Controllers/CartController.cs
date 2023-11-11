using BusiniessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.Controllers
{
    public class CartController : Controller
    {
        CartManager cartManager = new CartManager(new EfCartDal());
        AddressManager addressManager=new AddressManager(new EfAddressDal());
        Context db = new Context();
        public IActionResult Index()
        {
            var values = cartManager.TGetList();
            return View(values);
        }
        public IActionResult CartAdd(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.ProductId == id);
            Cart cart = new Cart();
            cart.ProductId = product.ProductId;
            cart.Product = product;
            cart.Price = (int)product.Price;
            cart.ProductImage = product.Image;
            cart.Quantity += 1;

            if (product != null)
            {
                cartManager.TAdd(cart);

            }


            return RedirectToAction("Index");
        }
        public IActionResult RemoveCart(int id)
        {
            var cart = db.Products.FirstOrDefault(y => y.ProductId == id);
            if (cart != null)
            {
                cartManager.TDelete(cart);
            }
            return RedirectToAction("Index");
        }
        public IActionResult AddressList()
        {
            var values= addressManager.TGetList();
            return View(values);
        }
    }
}
