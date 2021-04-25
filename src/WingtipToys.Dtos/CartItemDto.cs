using System;

namespace WingtipToys.Dtos {
    public class CartItemDto {
        public string CartId { get; set; }

        public string ItemId { get; set; }

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public int ProductId { get; set; }
    }
}