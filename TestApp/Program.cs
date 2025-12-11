using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();

            string url = "https://api.torn.com/user/2054568?selections=&key=lTXnTEVaHPhbKLRy";

            try
            {
                Console.WriteLine("Calling API...");

                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine("Response:");
                Console.WriteLine(responseBody);
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Request error: {ex.Message}");
            }
        }
    }
}