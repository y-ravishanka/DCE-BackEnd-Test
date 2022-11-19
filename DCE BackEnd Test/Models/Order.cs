namespace DCE_BackEnd_Test.Models
{
    public class Order
    {
        public string? OrderId { get; set; }
        public int OrderStatus { get; set; }
        public int OrderType { get; set; }
        public DateTime? OrderedOn { get; set; }
        public DateTime? ShippedOn { get; set; }
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public DateTime? ProductCreatedOn { get; set; }
        public bool ProductIsActive { get; set; }
        public string? SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public DateTime? SupplierCreatedOn { get; set; }
        public bool SupplierIsActive { get; set; }
    }
}