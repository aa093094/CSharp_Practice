﻿Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? rePlay = Console.ReadLine();

    if (rePlay == "Y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

string WinOrLose(int target, int roll)
{
    if (target < roll)
    {
        return "You win!";
    }
    else
    {
        return "You lose!";
    }
}