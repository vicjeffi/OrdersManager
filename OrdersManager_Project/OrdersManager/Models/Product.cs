using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManager.Models
{
    public class Product
    {
        private int _count;
        private string _name;
        private float _price;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public float Price
        {
            get { return _price; ; }
            set { _price = value; }
        }
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        public float TotalPrice
        {
            get { return _count * _price; }
        }
        public Product()
        {
            _name = "None"; _price = 50; Count = 1;
        }
        public Product(string name, float price, int count)
        {
            _name = name; _price = price; Count = count;
        }
        public override string ToString()
        {
            return Name + $" в колличестве {Count} шт.";
        }
    }
}
