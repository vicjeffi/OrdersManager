using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManager.Models
{
    abstract class Product
    {
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
        public Product()
        {
            _name = "None"; _price = 0;
        }
        public Product(string name, float price)
        {
            _name = name; _price = price;
        }
    }
}
