using System.ComponentModel.DataAnnotations;

namespace BookStoreApp_Blazor.Server.UI.Data
{
    public partial class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Title { get; set; }

        [Required]
        [Range(1500, int.MaxValue)]
        public int? Year { get; set; }

        [Required]
        public string Isbn { get; set; } = null!;

        [Required]
        [StringLength(250, MinimumLength = 10)]
        public string? Summary { get; set; }

        public string? Image { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public decimal? Price { get; set; }

        public int? AuthorId { get; set; }

        public virtual Author? Author { get; set; }
    }
}
