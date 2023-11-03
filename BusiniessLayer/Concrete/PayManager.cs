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
    public class PayManager : IPayService
    {
        IPayDal _payDal;

        public PayManager(IPayDal payDal)
        {
            _payDal = payDal;
        }

        public Pay GetById(int id)
        {
            return _payDal.GetById(id);
        }

        public void TAdd(Pay t)
        {
            _payDal.Insert(t);
        }

        public void TDelete(Pay t)
        {
            _payDal.Delete(t);
        }

        public List<Pay> TGetList()
        {
            return _payDal.GetList();
        }

        public void TUpdate(Pay t)
        {
            _payDal.Update(t);
        }
    }
}
