namespace TheDuelÖvning
{
    public class Player
    {

        public int Health { get; set; }
        public int Damage { get; set; }

        public Player(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }
        public int RollDamage()
        {
            // returna random int 

            Random randomDamage = new Random();

            return randomDamage.Next(0, 25);
        }

    }
}
