using System.Security.AccessControl;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
bool validRole = false;

do
{
    string? userInput;
    userInput = Console.ReadLine();

    if (userInput != null)
    {
        userInput = userInput.Trim().ToLower();
    }

    if (userInput == "administrator" || userInput == "manager" || userInput == "user")
    {
        validRole = true;
        Console.WriteLine($"Your input value ({userInput}) has been accepted.");
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }
} while (!validRole);
