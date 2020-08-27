using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Delivery
    {
        public Delivery()
        {
            Order = new List<Order>();
        }
        public Guid ID { get; set; }
        public string Address { get; set; }
        public DateTime DateTime { get; set; }
        public Guid OrderID { get; set; }
        public List<Order> Order { get; set; }
    }
}
