using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Entities {
    public class ProductEntity : BaseEntity {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public double UnitPrice { get; set; }

        public int CategoryId { get; set; }
    }
}