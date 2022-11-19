namespace DCE_BackEnd_Test.Models
{
    public class Product
    {
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string? SupplierId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}