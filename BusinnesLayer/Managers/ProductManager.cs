using BusinnesLayer.Services;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Managers
{
    public class ProductManager : IProductService
    {
        IProductDal _IProducDal;

        public ProductManager(IProductDal ıProducDal)
        {
            _IProducDal = ıProducDal;
        }

        public void Add(Product entity)
        {
            _IProducDal.Add(entity);
        }

        public void Delete(Product entity)
        {
           _IProducDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
           return _IProducDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _IProducDal.GetById(id);
        }

        public void Update(Product entity)
        {
            _IProducDal.Update(entity);
        }
    }
}
