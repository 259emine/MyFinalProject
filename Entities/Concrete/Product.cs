using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity//public yapdığımızda diğer katmanlarda ulaşabilsin
    {
        public int ProductId { get; set; } 
        public int CategoryId{ get; set; } //katogori 
        public string ProductName { get; set; } //ismi
        public short UnitsInStock { get; set; } //stok adedi
        public decimal UnitPrice { get; set; } //para birimi
    }
}
