namespace MyThinkBook.Web.Services
{
    public interface IGraphQLService
    {
        Task<HelloResponse> TestAsync();
    }
}