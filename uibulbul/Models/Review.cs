namespace uibulbul.Models
{
    public class Review
    {
        public int Id { get; set; }
        public float Rating {  get; set; }
        public int CarId { get; set; }
        public string Text { get; set; } = "";
        public string Author { get; set; } = "";
        public DateOnly Date {  get; set; }
    }
}
