namespace MyHTTPClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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