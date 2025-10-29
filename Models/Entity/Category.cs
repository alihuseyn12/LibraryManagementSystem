namespace LibraryManagementSystem.Models.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}