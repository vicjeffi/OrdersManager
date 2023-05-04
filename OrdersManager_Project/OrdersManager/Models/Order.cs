using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrdersManager.MainForm;

namespace OrdersManager.Models
{
    public class Order
    {

        private BindingList<Product> _products;
        private DateTime _time;
        private bool isComplited = false;
        public BindingList<Product> Products
        {
            get { return _products; }
            set { _products = value; }
        }
        public DateTime CreationTime
        {
            get { return _time; }
            set { _time = value; }
        }
        public float TotalPrice
        {
            get
            {
                float price = 0f;
                foreach(Product p in _products)
                {
                    price += p.Price * p.Count;
                }
                return price;
            }
        }
        public bool Complited { get { return isComplited; } set { isComplited = value; } }
        public Order(ICollection<Product> products, DateTime time)
        {
            _products = new BindingList<Product>();
            foreach (var p in products)
            {
                _products.Add(p);
            }
            _time = time;
        }
        public Order(ICollection<Product> products)
        {
            _products = new BindingList<Product>();
            foreach (var p in products)
            {
                _products.Add(p);
            }
            _time = DateTime.Now;
        }
        public Order(DateTime time)
        {
            _products = new BindingList<Product>();
            _time = time;
        }
        public Order()
        {
            _products = new BindingList<Product>();
            _time = DateTime.Now;
        }
        public override string ToString()
        {
            return CreationTime.ToString("dd-MM-yy") + " с " + _products.Count + " товарами " + (isComplited != true ? "(В сборке)" : "(Собран)");
        }
    }
}
