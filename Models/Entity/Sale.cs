namespace LibraryManagementSystem.Models.Entity
{
    public class Sale
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime SaleDate { get; set; }
    }
}