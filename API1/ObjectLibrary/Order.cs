using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectLibrary
{
    public class Order
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public Merchant Merchant { get; set; }
        public Person Person { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
