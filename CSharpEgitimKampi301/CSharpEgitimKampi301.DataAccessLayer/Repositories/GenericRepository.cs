using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
    // GenericRepository sınıfı, T türü için genel CRUD işlemlerini yapar.
    // T sadece class (referans tipi) olabilir.
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        // Veritabanı bağlantısını sağlayan context nesnesi.
        KampContext context = new KampContext();

        // İlgili entity'nin veritabanındaki karşılığı olan DbSet.
        private readonly DbSet<T> _object;

        // Constructor: T tipi için DbSet örneğini alır (örneğin context.Set<Product>())
        public GenericRepository()
        {
            _object = context.Set<T>();
        }

        // Verilen entity'yi siler.
        public void Delete(T entity)
        {
            // Entity'nin durumunu "Deleted" olarak işaretler.
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;

            // Değişiklikleri veritabanına uygular (DELETE sorgusu çalışır).
            context.SaveChanges();
        }

        // Tüm kayıtları getirir.
        public List<T> GetAll()
        {
            return _object.ToList(); // SELECT * FROM Tablo
        }

        // Belirli bir ID'ye sahip olan kaydı getirir.
        public T GetById(int id)
        {
            return _object.Find(id);// Primary Key ile arama yapar
        }

        // Yeni bir kayıt ekler.
        public void Insert(T entity)
        {
            // Entity'nin durumunu "Added" olarak işaretler.
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;

            // Değişiklikleri veritabanına uygular (INSERT sorgusu çalışır).
            context.SaveChanges();
        }

        // Var olan bir kaydı günceller.
        public void Update(T entity)
        {
            // Entity'nin durumunu "Modified" olarak işaretler.
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;

            // Değişiklikleri veritabanına uygular (UPDATE sorgusu çalışır).
            context.SaveChanges();
        }
    }
}
