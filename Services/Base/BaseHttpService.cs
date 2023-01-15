using Blazored.LocalStorage;

namespace BookStoreApp_Blazor.Server.UI.Services.Base
{
    public class BaseHttpService
    {
        private readonly IClient client;
        private readonly ILocalStorageService localStorage;

        public BaseHttpService(IClient client, ILocalStorageService localStorage)
        {
            this.client = client;
            this.localStorage = localStorage;
        }
        protected Response<Guid> ConvertApiException<Guid>(ApiException apiException)
        {
            if (apiException.StatusCode == 400)
            {
                return new Response<Guid>() { Message = "Validation erros have occured", ValidationErrors = apiException.Response, Succes = false };

            }
            if (apiException.StatusCode == 404)
            {
                return new Response<Guid>() { Message = "Validation erros have occured", ValidationErrors = apiException.Response, Succes = false };

            }

            return new Response<Guid>() { Message = "Something unexpecting have occured", ValidationErrors = apiException.Response, Succes = false };
        }

        protected async Task GetBearerToken()
        {
            var token = await localStorage.GetItemAsync<string>("accessToken");
            if (token != null)
            {
                client.HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", token);
            }
        }
    }
}
