namespace asm4
{
    public class GameCharacter
    {
        public string Name;
        public int Health;
        public string Role;

        public GameCharacter(string name, int health, string role)
        {
            Name = name;
            Health = health;
            Role = role;
        }


        public void TakeDamage(int damage)
        {
            Health -= damage;

            if (Health < 0)
            {
                Health = 0;
                
            }
            Console.WriteLine($"{Name} took {damage} damage. Remaining Health: {Health}");

            if (Health == 0)
            {
                Console.WriteLine("I have healed myself with the sacred cup of coffee.");
                Health += 18000;
                Console.WriteLine($"{Name}'s health is now : {Health}");
            }

        }
    }
}