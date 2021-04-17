using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rest_API_with_Db_First.Repository
{
   interface IRepository<TEntity> where TEntity:class
    {
        List<TEntity> GetAll();
        TEntity Get(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}