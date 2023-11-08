using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICartDal : IGenericDal<Cart>
    {
        public void Delete(Cart t)
        {
            throw new NotImplementedException();
        }

        public Cart GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cart> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Cart> GetListAll(Expression<Func<Cart, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Cart t)
        {
            throw new NotImplementedException();
        }

        public void Update(Cart t)
        {
            throw new NotImplementedException();
        }
    }

}
