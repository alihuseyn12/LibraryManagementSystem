using Microsoft.Extensions.Localization;

namespace LibraryManagementSystem.Models.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public int CopiesAvailable { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime PublishedYear { get; set; }
        public List<Sale> SaleList { get; set; } = new();
    }
}