using System.Threading.Tasks;
using RestSharp;

namespace Create.API.Client.Infrastructure
{
    public interface ICreateApiHttpClient
    {
        Task<T> GetAsync<T>(RestRequest request);
        string GetBaseUrl();
    }
}
