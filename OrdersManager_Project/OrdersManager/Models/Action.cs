using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManager.Models
{
    class Action
    {
        private string _actionDescription;
        private DateTime _time;
        public string Description
        {
            get { return _actionDescription; }
        }
        public DateTime CreationTime
        {
            get { return _time; }
        }
        public Action(string description)
        {
            _actionDescription = description;
            _time = DateTime.Now;
        }
    }
}
