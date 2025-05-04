namespace BookAPI.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
      
        public string Description { get; set; }
        public decimal price { get; set; }
 
        public string note { get; set; }
    }
}
