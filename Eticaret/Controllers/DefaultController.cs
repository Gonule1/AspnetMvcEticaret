using BusiniessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.Controllers
{
    public class DefaultController : Controller
    {
        ProductManager productManager= new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
       var values = productManager.TGetList();
            return View(values);
        }
        public ActionResult ProductReadAll(int Id)
        {
            var values= productManager.GetProductById(Id);
            return View(values);
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult SliderPartial()
        {
            return PartialView();
        }

    }
}
