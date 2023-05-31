using System.ComponentModel;

namespace ASPNETCore6._0Practice.Models
{
    public class Pie
    {
        // properties
        public int PieId { get; set; }
        public string Name { get; set; } = string.Empty; // name set to empty NOT nullable
        public string? ShortDescription { get; set; } // the '?' indicated that the string can be null and thus, not required
        public string? LongDescription { get; set; }
        public string? AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!; // defualt! is the null forgiving operator, declares that Category shouldn't be null
    }
}
