using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Please input your API key for use. A Public Only key works fine");
            string apiKey = Console.ReadLine();
            Console.WriteLine("Please input ID of user.");
            string userId = Console.ReadLine();
            string url = $"https://api.torn.com/user/{userId}?selections=&key={apiKey}";

            using HttpClient client = new HttpClient();

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