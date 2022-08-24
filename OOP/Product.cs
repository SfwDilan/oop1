using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Product
    {
        public int Id { get; set; } //primary key
        public int CategoryId { get; set; } //foreign key ve bunllar böyle ilk sıralarda yazılır. PK ilk sırada FK ikinci sırada
        public int UnitsInStock { get; set; }
        public double UnitPrice { get; set; }
        public string ProductName { get; set; }


    }
}
