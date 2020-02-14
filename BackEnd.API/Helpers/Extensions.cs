using Microsoft.AspNetCore.Http;

namespace BackEnd.API.Helpers
{
    // Static ==> We don't want to make a new instance of this class when we want to use this class.
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Header","Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}