using System;
using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Entities {
    public class CartItemEntity : BaseEntity {
        [Key]
        public string CartId { get; set; }

        public string ItemId { get; set; }

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public int ProductId { get; set; }
    }
}