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
    public class AddressManager : IAddressService
    {
        IAdressDal _addressDal;

        public AddressManager(IAdressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public Address GetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public void TAdd(Address t)
        {
            _addressDal.Insert(t);
        }

        public void TDelete(Address t)
        {
            _addressDal.Delete(t);
        }

        public List<Address> TGetList()
        {
            return _addressDal.GetList();
        }

        public void TUpdate(Address t)
        {
            _addressDal.Update(t);  
        }
    }
}
