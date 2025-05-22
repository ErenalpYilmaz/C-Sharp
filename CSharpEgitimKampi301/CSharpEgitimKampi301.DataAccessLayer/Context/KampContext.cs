using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    // Bir sınıfı veri tabanına yazdırmak istiyorsak . Bu alana eklemek zorundayız.
    public class KampContext : DbContext
    {
        //Category -> C# Tarafinda kullanilacak class ismi.
        //Categories -> Sql e yansiyacak tablo ismi.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
