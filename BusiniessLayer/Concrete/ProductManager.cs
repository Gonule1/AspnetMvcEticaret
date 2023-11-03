using BusiniessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusiniessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetProductById(int id) {
            return _productDal.GetListAll(x=>x.ProductId==id);
        
        }
        public Product GetById(int id)
        {
           return _productDal.GetById(id);
        }

        public void TAdd(Product t)
        {
            _productDal.Insert(t);
        }

        public void TDelete(Product t)
        {
           _productDal.Delete(t);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
