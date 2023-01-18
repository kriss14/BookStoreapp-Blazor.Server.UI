using BookStoreApp_Blazor.Server.UI.Data;
namespace BookStoreApp_Blazor.Server.UI.Services.AuthorServices
{
    public class AuthorState
    {
        public Author Author { get; private set; }

        public event Action OnChange;

        public void SetAuthor(Author author)
        {
            Author = author;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
