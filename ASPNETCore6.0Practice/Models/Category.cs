namespace ASPNETCore6._0Practice.Models
{
    public class Category
    {
        // used to introduce Category type
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Pie>? Pies { get; set; }
    }
}
