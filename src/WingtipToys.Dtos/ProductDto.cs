namespace WingtipToys.Dtos {
    public class ProductDto {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }
    }
}