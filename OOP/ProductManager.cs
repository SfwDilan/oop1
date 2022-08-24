using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ProductManager
    {
        // CRUD(Ekleme-Silme-Güncelleme-Filtreleme gibi işlemleri ProductManager isimli sınıfta yaparız.)
        // Class'ın Sonunda Manager-Service-DataAccess,Controller gibi ifadeleri görürsen bunlar bir operasyon yani bir metot tutuyor demektir.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public  void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        
    }
}
