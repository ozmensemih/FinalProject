using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

// namespace kolaylıkla ulaşabilmek için oluşturulan isim uzayı
namespace Core.DataAccess
{
    //generic constraint /generict kısıt anlamında 
    //where T:class referans tipi belirtiyoruz. böylelikle sadece izin verilenleri kabul eder. int vb veremesin
    //IEntity den türemiş olması gerkir filtresi Benim oluşturduğum Entties içi
    //IEntity olabilir veya IEntitiyden implement edilmiş olması gerekir.
    //new() newlenebilir olmalı anlamında. IEntitiy newlenemediği için IEntity izin vermeyecek ICategoryDal
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Linq Koşullu sorgu kullanabilmek için EXpression<Func<T,bool>> filter= null Eklenmiştir.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
      
    }
}
