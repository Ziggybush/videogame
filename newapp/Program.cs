namespace videogame
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Epic Video Game";
            await CharacterCreation.CreateCharacter();
            Console.ReadKey();
        }
    }
}
