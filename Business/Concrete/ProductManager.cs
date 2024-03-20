using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Caching;
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

        //Soyut nesneyle baglanti kuruyruz.Ne Inmemory ismi ne de entity framework ismi gecmiyor.
        IProductDal _productDal;
       

        //ProductManager new lendiginde bana bir IProductDal refereansi ver diyor.(InMemory EntityFramework..)
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
            
        }

        //Burada AOP yapilanmasi kullaniyorum.Yani Add methodu calistirilmadan once methodun ustune bakiliyor.
        //Eger Add methodundan once calistirilmasi gereken kodlar varsa onlari calistiriyor.
        //Burada ise ekleme islemi yapilmadan ilgili kullanicinin yetkisi olup olmadigi kontrol ediliyor.
        //Eger kullanicinin "product.add,admin" yetkileri varsa urun ekleyebilir.
        //Boylelikle methodun ici cok temiz olup kod karmasikligi onleniyor.Loglama ,Caching gibi yapilanmalari AOP sayesinde bu sekilde entegre edebilirim.

        [SecuredOperation("product.add,admin")]
      //  [CacheRemoveAspect("IProductService.Get")]//IProductService teki butun Get'leri siler.
        public IResult Add(Product product)

        {

            _productDal.Add(product);
            return new SuccessResult("Product added");

        }
        [CacheAspect]
        public IDataResult<List<Product>> GetAll()
        {
            //is kodlarini geciyorsa veri erisimi cagiririz.
            // InMemoryProductDal inMemoryProductDal = new InMemoryProductDal(); EGER BOYLE YAZARSAK IS KODLARIMIZIN TAMAMI BELLEKLE CALISIR.
            //NOT:Bir is sinifi baska siniflari new lemez.Injeksion yapariz
            
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), " Products listed.");

        }


        [SecuredOperation("product.add,admin")]

        public IResult Update(Product product)
        {
            return new SuccessResult("Product updated");
        }

        [SecuredOperation("product.add,admin")]

        public IResult Delete(Product product)
        {


            return new SuccessResult("Product deleted");
        }

       
    }

    }
