using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class OrderModel
    {
        public OrderModel()
        {
            ClothesModel = new List<ClothesModel>();
        }
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public Guid ClothesID { get; set; }
        public List<ClothesModel> ClothesModel { get; set; }
    }
}
