namespace asm4
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter firstGameCharacter = new GameCharacter("Allan Pead", 9000, "The Commander");
            Console.WriteLine($"Player Name: {firstGameCharacter.Name}, Player Health: {firstGameCharacter.Health}, Player Role: {firstGameCharacter.Role}");


            firstGameCharacter.TakeDamage(2000);
            firstGameCharacter.TakeDamage(3000);
            firstGameCharacter.TakeDamage(5000); // Should not go below 0

            Console.ReadKey();
        }
    }
}
