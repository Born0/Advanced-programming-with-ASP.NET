using Rest_API_with_Db_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rest_API_with_Db_First.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity:class
    {
        protected InventoryDBEntities context = new InventoryDBEntities();
        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }
        public TEntity Get(int id)
        {
            return context.Set<TEntity>().Find(id);
        }
        public void Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(int id)
        {

            context.Set<TEntity>().Remove(Get(id));
            context.SaveChanges();
        }
    }
}