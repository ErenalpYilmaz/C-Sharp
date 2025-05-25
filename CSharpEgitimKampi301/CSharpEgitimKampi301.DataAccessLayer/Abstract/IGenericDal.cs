using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class //  bu ifade, yalnızca referans tipleriyle (class'larla) çalışabilen ve türü çalışma anında belirlenen genel (generic) bir veri erişim arayüzünü tanımlar.
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity); //Belirtilen id'ye sahip öğeyi silen bir metodu tanımlar
        List<T> GetAll(); //Tüm öğeleri içeren bir listeyi döndüren metodu tanımlar.
        T GetById(int id); //Belirtilen id'ye sahip öğeyi döndüren metodu tanımlar.
    }
}
