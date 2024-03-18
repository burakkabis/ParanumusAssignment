using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        //Soyut nesneyle baglanti kuruyruz.Ne Inmemory ismi ne de entity framework ismi gececek.
        IProductDal _productDal;
       

        //ProductManager new lendiginde bana bir IProductDal refereansi ver diyor.(InMemory EntityFramework..)
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
            
        }

        [SecuredOperation("product.add,admin")]
        public IResult Add(Product product)

        {

            _productDal.Add(product);
            return new SuccessResult("Product added");

        }
        public IDataResult<List<Product>> GetAll()
        {
            //is kodlarini geciyorsa veri erisimi cagiririz.
            // InMemoryProductDal inMemoryProductDal = new InMemoryProductDal(); EGER BOYLE YAZARSAK IS KODLARIMIZIN TAMAMI BELLEKLE CALISIR.
            //NOT:Bir is sinifi baska siniflari new lemez.Injeksion yapariz
            
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), " Products listed.");

        }



        public IResult Update(Product product)
        {
            return new SuccessResult("Product updated");
        }

        public IResult Delete(Product product)
        {


            return new SuccessResult("Product deleted");
        }

       
    }

    }
