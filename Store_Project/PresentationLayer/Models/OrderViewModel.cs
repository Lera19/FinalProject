using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Models

{
    public class OrderViewModel
    {
        public OrderViewModel()
        {
            Clothes = new List<ClothesViewModel>();
        }
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ClothesId { get; set; }
        public List<ClothesViewModel> Clothes { get; set; }
    }
}
