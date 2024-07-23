namespace MyHTTPClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //await Method_1();
            await Method_2();
        }
        static async Task<string> Method_1()
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetStringAsync("https://www.google.com/");
                return result;
            }
        }

        static async Task Method_2()
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync("https://www.google.com/");

                //    //var result = response.Content.ReadAsStringAsync().Result;
                using (StreamReader sr = new StreamReader(await result.Content.ReadAsStreamAsync()))
                {
                    string result2 = sr.ReadToEnd();
                    Console.WriteLine(result2);
                }

            }
        }
    }
}