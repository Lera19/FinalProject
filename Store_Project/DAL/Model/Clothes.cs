using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Clothes
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
        public Guid CategoryId { get; set; }
        public Guid TypeId { get; set; }

    }
}
