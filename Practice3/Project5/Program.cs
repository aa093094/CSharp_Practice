Console.WriteLine("Enter an integer value between 5 and 10");
bool validNumber = false;

do
{
    string? userInput;
    userInput = Console.ReadLine();
    int numericValue = 0;

    validNumber = int.TryParse(userInput, out numericValue);
    if (validNumber)
    {
        if (numericValue >= 5 && numericValue <= 10)
        {
            Console.WriteLine($"Your input value ({numericValue}) has benn accepted.");
        }
        else
        {
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
            validNumber = false;
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
    }
} while(!validNumber);
