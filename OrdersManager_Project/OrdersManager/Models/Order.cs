using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManager.Models
{
    class Order
    {
        public BindingList<Product> products;
        public float TotalPrice
        {
            get
            {
                float price = 0f;
                foreach(Product p in products)
                {
                    price += p.Price * (p as ICountable).Count;
                }
                return price;
            }
        }
        public Order()
        {
            
        }
    }
}
