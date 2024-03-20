using Core.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{

    //IEntityRepository:Core/DataAccess katmaninda bulununan ve butun entitiyler icin base gorevi gorecek Dal(Data Access Layer),veri tabani islemlerinin base i konumundadir.
    public interface IProductDal:IEntityRepository<Product>
    {

 
    }
}
