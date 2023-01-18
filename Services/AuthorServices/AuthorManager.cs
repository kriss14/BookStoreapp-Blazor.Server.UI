using BookStoreApp_Blazor.Server.UI.Data;
using BookStoreApp_Blazor.Server.UI.Services.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp_Blazor.Server.UI.Services.AuthorServices
{
    public class AuthorManager : IAuthor
    {
        private readonly BookStoreDbContext bookStoreDbContext;

        public AuthorManager(BookStoreDbContext bookStoreDbContext)
        {
            this.bookStoreDbContext = bookStoreDbContext;
        }
        public async Task<List<Author>> GetAuthorList()
        {
            var authorList = await bookStoreDbContext.Authors.ToListAsync();
            return authorList;
        }

        public async Task<IActionResult> DeleteAuthor(int id)
        {

            var author = await bookStoreDbContext.Authors.FindAsync(id);
            if (author == null)
            {
                return null;
            }

            bookStoreDbContext.Authors.Remove(author);
            await bookStoreDbContext.SaveChangesAsync();
            return null;
        }

        public async Task CreateAuthor(Author author)
        {
           bookStoreDbContext.Add(author);
           await bookStoreDbContext.SaveChangesAsync();
           
        }

        public async Task UpdateAuthor(int id)
        {
            var author = await bookStoreDbContext.Authors.FindAsync(id);
 
            bookStoreDbContext.Entry(author).State = EntityState.Modified;
            await bookStoreDbContext.SaveChangesAsync();
        }
    }
}
