using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    
        public bool CategoryStatus { get; set; }
    }
}
/*
 Field - Variable - Property
 */

/*
    int x; --> Field  Direkt sınıfın içine tanımlanırsa field'dır.
    public int y { get; set; } --> get ve set aldigi icin bu bir property oluyor.
    Variable --> Eğer bir method içinde tanımlanırsa variable olur.
 */