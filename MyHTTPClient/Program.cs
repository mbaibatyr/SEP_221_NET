namespace MyHTTPClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await Method_1();
        }
        static async Task<string> Method_1()
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetStringAsync("https://www.google.com/");
                return result;
            }
        }
    }
}