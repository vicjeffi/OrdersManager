using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManager.Models.Products
{
    class Apple : Product, ICountable
    {
        private int _count;
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        public Apple() : base() { }
        public Apple(int count) : base("Яблоко", 150.99f)
        {
            Count = count;
        }
        public override string ToString()
        {
            return string.Join(" ", Name, "Цена: " + Price, "Количество: " + Count);
        }
    }
}
