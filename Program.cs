namespace asm4
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter firstGameCharacter = new GameCharacter("Allan Pead", 9000, "The Commander");
            Console.WriteLine($"Player Name: {firstGameCharacter.Name}, Player Health: {firstGameCharacter.Health}, Player Role: {firstGameCharacter.Role}");

            //firstGameCharacter.TakeDamage(2000);
            //firstGameCharacter.TakeDamage(3000);
            while (true) // This loop will keep running forever unless you break it
            {
                Console.Write("Use a weapon to battle allan(hint: sword): ");
                string input = Console.ReadLine();

                if (input == "sword")
                {
                    firstGameCharacter.TakeDamage(5000);
                }

                if (input == "exit") // Optional: way to stop the loop
                {
                    Console.WriteLine("Exiting the game...");
                    break;
                }

            }
            



            //Console.ReadKey();
        }
    }
}
