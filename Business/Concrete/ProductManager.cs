using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //busines codes yani iş kodları yazılır

            if (product.ProductName.Length<2)
            {
                return new ErrorResult(Massages.ProductNameInvalid);
            }
            _productDal.Add(product);

            return new SuccessResult(Massages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 14)
             {
                return new ErrorDataResult<List<Product>>(Massages.MaintenanceTime);
             }


            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Massages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.CategoryId==id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p=>p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>> (_productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max));
        }

        public IDataResult<List<ProductDetaiIDto>> GetProductDetaiIs()
        {

            return new SuccessDataResult<List<ProductDetaiIDto>> (_productDal.GetProductDetaiIs());
        }
    }
}
