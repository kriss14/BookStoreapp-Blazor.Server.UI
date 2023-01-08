using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using BookStoreApp_Blazor.Server.UI.Data;

namespace BookStoreApp_Blazor.Server.UI.Data
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }

        [StringLength(250)]
        public string? Bio { get; set; }

        public virtual ICollection<Book> Books { get; } = new List<Book>();
    }

}
