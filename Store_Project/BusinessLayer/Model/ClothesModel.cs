using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class ClothesModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
        public Guid CategoryID { get; set; }
        public Guid TypeID { get; set; }

    }
}
