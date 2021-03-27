using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint -- generic kısıtlayıcı
    //class : referans tip olmalı
    //IEntity : ya IEntity olucak ya da IEntityi implement edicek
    //new() : new lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //filtre yapmamızı sağlıyor(linq gibi) -- null ise filtre yapmadan da kullanabiliriz.
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        //filtre yapmak zorunlu(linq gibi)
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
