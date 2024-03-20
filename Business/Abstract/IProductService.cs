using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        //IDataResult in icerisinde;bool success,string message,T data bulunuyor.GetAll methodu cagrildiginda geriye bunlari da donduruyor.
        IDataResult<List<Product>> GetAll();
        //Void olan yerde IResult donduruyoruz.
        IResult Add(Product product);
        IResult Update(Product product);

        IResult Delete(Product product);

    }
}
