using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    //Generic constraint:Generic kisitlama
    //Butun projelerde kullanilacak olan Entitiy Framework icin genel bir base gorevi gorurur.
    //Yapilanma generic oldugu icin sadece entity ve context nesnelerini verdigimizde butun CRUD operasyonlarini gerceklestirebilir.
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
       where TEntity : class, IEntity, new()//TEntity:IEntity implemente etmis bir class alabilir.Bunlarda Entities katmaninda bulunan nesnelerimizdir.Generic constraint yapmis bulunuyorum.
       where TContext : DbContext, new()
    {

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())

            {
                var addedEntity = context.Entry(entity);//referansi yakalar.
                addedEntity.State = EntityState.Added;//Veri tabannda ekleme islemi yapar.
                context.SaveChanges();

            }
        }

        public void Delete(TEntity entity)
        {

            using (TContext context = new TContext())

            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;//Veritabaninda silme islemi yapar.
                context.SaveChanges();

            }
        }

        //Tek bir data getirecek.

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {

            using (TContext context = new TContext())

            {
                return context.Set<TEntity>().SingleOrDefault(filter);


            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {

            using (TContext context = new TContext())

            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();


            }
        }

        public void Update(TEntity entity)
        {

            using (TContext context = new TContext())

            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

    }
}
