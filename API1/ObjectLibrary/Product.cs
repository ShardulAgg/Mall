using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectLibrary
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int Price { get; set; }
        public Store Store { get; set; }
    }
}
