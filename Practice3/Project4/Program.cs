int playerHp = 10;
int enemyHp = 10;

do
{
    Random random = new Random();
    int playerAtk = random.Next(1, 11);
    enemyHp -= playerAtk;
    Console.WriteLine($"Monster was damaged and lost {playerAtk} health and now has {enemyHp} health.");
    if (enemyHp > 0)
    {
        int enemyAtk = random.Next(1, 11);
        playerHp -= enemyAtk;
        Console.WriteLine($"Hero was damaged and lost {enemyAtk} health and now has {playerHp} health.");
    }

} while( playerHp > 0 && enemyHp > 0);

if (playerHp > 0)
{
    Console.WriteLine("Hero wins!");
}
else
{
    Console.WriteLine("Monster wins!");
}