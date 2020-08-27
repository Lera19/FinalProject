using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class DeliveryModel
    {
        public DeliveryModel()
        {
            OrderModels = new List<OrderModel>();
        }
        public Guid ID { get; set; }
        public string Address { get; set; }
        public DateTime DateTime { get; set; }
        public Guid OrderID { get; set; }
        public List<OrderModel> OrderModels { get; set; }
    }
}
