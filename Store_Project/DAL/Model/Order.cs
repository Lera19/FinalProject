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
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ClothesId { get; set; }
        public List<Clothes> Clothes { get; set; }
    }
}
