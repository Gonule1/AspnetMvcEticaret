using BusiniessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.ViewComponents
{
    public class CategoryList : ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke() 
        {
            var values = categoryManager.TGetList().Where(x => x.Status == true);
            return View(); }
    }
}