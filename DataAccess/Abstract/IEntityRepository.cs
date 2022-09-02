using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class ,IEntity,new()
    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null);  //Filtre vermesekte olur kodu
        T Get(Expression<Func<T, bool>> filter);  // FIltre vermemizi saglar
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       // List<T> GetAllByCategory(int categoryId);  Expression ile filtreleme yatik ve bu satirdaki koda ihtiyacimiz kalmadi


    }
}
