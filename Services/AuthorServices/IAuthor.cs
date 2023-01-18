using BookStoreApp_Blazor.Server.UI.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp_Blazor.Server.UI.Services.AuthorServices
{
    public interface IAuthor
    {
        public Task<List<Author>> GetAuthorList();
        public Task<IActionResult> DeleteAuthor(int id);
        public Task CreateAuthor(Author author);
        public Task UpdateAuthor(int id);

    }
}
