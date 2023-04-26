using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrdersManager.MainForm;

namespace OrdersManager.Models
{
    public class Customer : ICloneable, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event AccountHandler Notify;
        private string _firstName;
        private string _lastName;
        private string _fatherName;
        private BindingList<Order> _orders;
        public Customer()
        {
            Name = "None"; FatherName = "None"; LastName = "None";
            _orders = new BindingList<Order>();
        }
        public Customer(string firstname, string lastname, string fathername)
        {
            Name = firstname; FatherName = lastname; LastName = fathername;
            _orders = new BindingList<Order>();
        }
        public string Name
        {
            get { return _firstName; }
            set { _firstName = value; OnPropertyChanged("Name"); }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; OnPropertyChanged("LastName"); }
        }
        public string FatherName
        {
            get { return _fatherName; }
            set { _fatherName = value; OnPropertyChanged("FatherName"); }
        }
        public string FullName
        {
            get { return string.Join(" ", Name, LastName, FatherName); }
        }
        public BindingList<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }
        public bool HasComlitedOrders 
        { 
            get
            {
                foreach (var order in Orders)
                    if (order.Complited)
                        return true;
                return false;
            } 
        }
        public override string ToString()
        {
            return FullName;
        }
        public void Became(Customer intoCustomer)
        {
            this.FatherName = intoCustomer.FatherName;
            this.Name = intoCustomer.Name;
            this.LastName = intoCustomer.LastName;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
