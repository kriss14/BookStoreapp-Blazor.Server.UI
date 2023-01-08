using Microsoft.EntityFrameworkCore;

namespace BookStoreApp_Blazor.Server.UI.Data
{
    public class AuthorContext : DbContext
    {
        public AuthorContext(DbContextOptions<AuthorContext> options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author() { Id = 1, FirstName = "John", LastName = "Snow", Bio = " born Aegon Targaryen, is the son of Lyanna Stark and Rhaegar Targaryen, the late Prince of Dragonstone" },
                new Author() { Id = 2, FirstName = "John2", LastName = "Snow2", Bio = " born Aegon Targaryen, is the son of Lyanna Stark and Rhaegar Targaryen, the late Prince of Dragonstone" },
                new Author() { Id = 3, FirstName = "John3", LastName = "Snow3", Bio = " born Aegon Targaryen, is the son of Lyanna Stark and Rhaegar Targaryen, the late Prince of Dragonstone" }
                );
        }


    }
}
