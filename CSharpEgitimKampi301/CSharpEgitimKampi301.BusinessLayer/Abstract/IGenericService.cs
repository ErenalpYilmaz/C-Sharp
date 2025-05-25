using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(T entity); //Belirtilen id'ye sahip öğeyi silen bir metodu tanımlar
        List<T> TGetAll(); //Tüm öğeleri içeren bir listeyi döndüren metodu tanımlar.
        T TGetById(int id); //Belirtilen id'ye sahip öğeyi döndüren metodu tanımlar.
    }
}
