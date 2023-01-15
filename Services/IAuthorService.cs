using BookStoreApp_Blazor.Server.UI.Services.Base;
namespace BookStoreApp_Blazor.Server.UI.Services
{
   public  interface IAuthorService
    {
        Task<Response<List<AuthorReadOnlyDto>>> GetAuthors();
    }

}