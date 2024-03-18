using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        //fitler=null filtre vermeyedebilir.
        //filtre vermemisse tum datayi istiyor demektir.Boyle bir mantik kurabilirsin.
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //Biz bu yapiyla categoriye gore getir ,urunun fiyatina gore getir vs.
        //ayri ayri methodlar yazmaya gerek kalmayacak

        //filter zorunlu.
        T Get(Expression<Func<T, bool>> filter); //Tek bir data getirmek icin.Genelde bir sistemde bir seyin detayina gitmek icin kullnailir.
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}
