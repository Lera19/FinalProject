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
        {}
        public Guid Id { get; set; }
        public string Address { get; set; }
        public DateTime DateTime { get; set; }
        public Guid OrderId { get; set; }
    }
}
