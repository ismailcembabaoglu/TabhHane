using System.Net.Http.Json;
using TabhHane.Shared.CustomExceptions;
using TabhHane.Shared.ResponseModels;

namespace TabhHane.Client.Utils
{
    public static class HttpClientExtension
    {
        public async static Task<T>GetServiceResponseAsync<T>(this HttpClient httpClient,string url,bool throwWhenNotSuccess = false)
        {
            var httpRes=await httpClient.GetFromJsonAsync<ServiceResponse<T>>(url);
            if (!httpRes.Success && throwWhenNotSuccess)
            {
               throw new ApiException(httpRes.Message);
            }
            return httpRes.Value;
        }
    }
}
