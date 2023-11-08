using BusiniessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusiniessLayer.Concrete
{
    public class CartManager : ICartService
    {
        ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public Cart GetById(int id)
        {
            return _cartDal.GetById(id);
        }

        public void TAdd(Cart t)
        {
            _cartDal.Insert(t);
        }

        public void TDelete(Cart t)
        {
            _cartDal.Delete(t);
        }

        public List<Cart> TGetList()
        {
            return _cartDal.GetList();
        }

        public void TUpdate(Cart t)
        {
            _cartDal.Update(t);
        }
    }
}
