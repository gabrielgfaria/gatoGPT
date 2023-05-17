using ManagedCode.OpenAI.Client;

namespace gatoEuPeidei_Service
{
    public class Class1
    {
        private const string OPENAI_API_KEY = "";

        public async Task PrintOutputToScreen()
        {
            var client = GptClient.Builder(OPENAI_API_KEY).Build();

            var img = await client.ImageClient
                .GenerateImage("A CAT FARTING IN SPACE")
                .AsUrl()
                .ExecuteAsync();

            var url = img.Content;
            Console.WriteLine(url);
        }
    }
}