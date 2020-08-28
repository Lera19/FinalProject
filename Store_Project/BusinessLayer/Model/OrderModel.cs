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
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ClothesId { get; set; }
        public List<ClothesModel> ClothesModel { get; set; }
    }
}
