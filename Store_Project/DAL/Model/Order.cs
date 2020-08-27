using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Order
    {
        public Order()
        {
            Clothes = new List<Clothes>();
        }
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public Guid ClothesID { get; set; }
        public List<Clothes> Clothes { get; set; }
    }
}
