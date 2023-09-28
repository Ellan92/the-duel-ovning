// Skapa en spelarklass med 2 properties: Health och Damage
// Skapa två instanser av spelare-klassen (playerOne och playerTwo) och ge båda hälsa och skada via constructorn

using TheDuelÖvning;

bool isRunning = true;

Player playerOne = new(200, 0);

Player playerTwo = new(200, 0);

Random whichPlayerStarts = new Random();

bool playerOneStarts = whichPlayerStarts.Next(2) == 0;



while (playerOne.Health > 0 && playerTwo.Health > 0)
{

    if (playerOneStarts)
    {
        Console.Clear();
        Console.WriteLine("Player one starts!");
        Console.WriteLine("Press any key to attack!");
        Console.ReadKey();

        int damageDone = Attack(playerOne, playerTwo);


        Console.WriteLine($"Player one hit Player two for {damageDone} damage);");
        Console.WriteLine($"Player two has {playerTwo.Health} health-points remaining");
        Console.ReadKey();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Player two starts!");
        Console.WriteLine("Press any key to attack!");
        Console.ReadKey();

        int damageDone = Attack(playerTwo, playerOne);


        Console.WriteLine($"Player two hit Player one for {damageDone} damage);");
        Console.WriteLine($"Player one has {playerOne.Health} health-points remaining");
        Console.ReadKey();
    }
    playerOneStarts = !playerOneStarts;

}

if (playerOne.Health < 0)
{
    Console.WriteLine("Player 2 won!");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Player 1 won!");
    Console.ReadKey();
}

int CalculateRemainingHealth(Player attackedPlayer, Player totalHealth)
{
    int remainingHealth = attackedPlayer.Health;
    return remainingHealth;
}
int Attack(Player attackingPlayer, Player attackedPlayer)
{
    int damage = attackingPlayer.RollDamage();

    attackedPlayer.Health -= damage;

    return damage;
}

int CriticalAttack(Player attackingPlayer, Player attackedPlayer)
{
    int criticalDamage = attackingPlayer.RollCriticalDamage();

    attackedPlayer.Health -= criticalDamage;

    return criticalDamage;
}


//int RandomDamage(int randomDamage)
//{

//    Random randomDamage = new Random();

//    return randomDamage.Next(0, 25);
//}


