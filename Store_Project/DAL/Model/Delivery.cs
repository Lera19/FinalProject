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
        { }
        public Guid Id { get; set; }
        public string Address { get; set; }
        public DateTime DateTime { get; set; }
        public Guid OrderId { get; set; }
    }
}
