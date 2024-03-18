for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        if (i % 5 == 0)
        {
            Console.WriteLine($"{i} - FizzBuzz");
        }
        else
        {
            Console.WriteLine($"{i} - Fizz");
        }
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}